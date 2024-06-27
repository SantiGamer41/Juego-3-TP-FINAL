using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    GameObject[] comidasEnPlano;

    // Start is called before the first frame update
    void Start()
    {
        deactivateAll();
        comidaRandom = Random.Range(0, comida.Length-1);
        maxApariciones = Random.Range(3, 10);
        InvokeRepeating(nameof(aparecerComida), 0, interval);
        
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
}
