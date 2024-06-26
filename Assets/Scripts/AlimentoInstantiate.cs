using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlimentoInstantiate : MonoBehaviour
{
    public int index = -1;
    public GameObject[] comida;
    public GameObject[] comidasEnPlano;
    
    // Start is called before the first frame update
    void Start()
    {
        deactivateAll();
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void deactivateAll()
    {
        for (int i = 0; i <= comida.Length - 1; i++)
        {
            comida[i].SetActive(false);
        }
    }
    void aparecerComida()
    {
        for (int i = Random.Range(0, comida.Length - 1); i < comida.Length - 1; i = Random.Range(0, comida.Length - 1))
        {
            // comida[i]
        }
    }
}
