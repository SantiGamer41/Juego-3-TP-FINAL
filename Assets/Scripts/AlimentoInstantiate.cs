using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AlimentoInstantiate : MonoBehaviour
{
    //
    public Vector3 newPosition;

    //Declaración del Array
    
    public int index = 1;
    public GameObject[] comida;
    //declaración de que comida se usa y cuantas veces aparecen
    public int comidaRandom;
    public int maxApariciones;
    //Chequeo de comidas
    public InputField ingresoComida;
    public Button btnResponder;

    // Start is called before the first frame update
    void Start()
    {
        deactivateAll();
        comidaRandom = Random.Range(0, comida.Length-1);
        maxApariciones = Random.Range(3, 10);
        InvokeRepeating(nameof(aparecerComida), 0, interval);
        btnResponder.onClick.AddListener(Responder);

    }
    
    public float interval;

    // Update is called once per frame
    void Update()
    {
        //if ()
        //{
        //    aparecerComida();
        //}
    }
    void deactivateAll()
    {
        for (int i = 0; i <= comida.Length - 1; i++)
        {
            comida[i].SetActive(false);
        }
    }
    void Activate()
    {
       
        
            comida[comidaRandom].SetActive(true);
        
    }
    void aparecerComida()
    {


        
        if (index < maxApariciones)
        {
            Activate();
            Instantiate(comida[comidaRandom], newPosition, Quaternion.identity);
            index++;
        }
        else
        {
            CancelInvoke(nameof(aparecerComida));
        }



    }
    void Responder()
    {
        if (ingresoComida != null)
        {
            
            string textoIngresado = ingresoComida.text;

            // Intentar convertir el texto a un número
            int numeroIngresado = int.Parse(textoIngresado);
            

            if (numeroIngresado == maxApariciones)
            {
                Debug.Log("¡Correcto! El número ingresado es igual a maxApariciones.");
                // Aquí puedes ejecutar cualquier acción adicional que desees
            }
            else
            {
                Debug.Log("El número ingresado no es igual a maxApariciones.");
            }
        }
    }
}
