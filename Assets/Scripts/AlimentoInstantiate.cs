using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlimentoInstantiate : MonoBehaviour
{
    //
    public Vector3 newPosition;

    //Declaración del Array
    public int comidaRandom;
    public int index = -1;
    public GameObject[] comida;

    //Chequeo de comidas
    GameObject[] comidasEnPlano;

    // Start is called before the first frame update
    void Start()
    {
        deactivateAll();
        comidaRandom = Random.Range(0, comida.Length-1);
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
       
        
            Activate();
            Instantiate(comida[comidaRandom], newPosition, Quaternion.identity);
        
    }
}
