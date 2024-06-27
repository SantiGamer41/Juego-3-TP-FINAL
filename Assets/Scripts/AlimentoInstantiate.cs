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
    public GameObject panelCorrecto;
    public GameObject panelIncorrecto;
    public GameObject panelGeneral;
    public GameObject panelRespuestaVacia;
    public Button btnRespVacia;
    public Button btnCorrecto;
    public Button btnIncorrecto;
    // Start is called before the first frame update
    void Start()
    {

        deactivateAll();
        panelGeneral.SetActive(false);
        comidaRandom = Random.Range(0, comida.Length - 1);
        maxApariciones = Random.Range(3, 10);
        InvokeRepeating(nameof(aparecerComida), 0, interval);
        btnResponder.onClick.AddListener(Responder);
        btnCorrecto.onClick.AddListener(ReiniciarConValoresAleatorios);
        btnIncorrecto.onClick.AddListener(ReiniciarConMismosValores);
        btnIncorrecto.onClick.AddListener(CerrarPanelVacio);
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
            panelGeneral.SetActive(true);
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
                panelCorrecto.SetActive(true);
            }
            else if (numeroIngresado != maxApariciones)
            {
                panelIncorrecto.SetActive(true);
            }
            else if (ingresoComida.text == null)
            {
                panelRespuestaVacia.SetActive(true);
            }
        }
        
    }
    void ReiniciarConValoresAleatorios()
    {
        panelGeneral.SetActive(false);
        panelCorrecto.SetActive(false);
        panelIncorrecto.SetActive(false);


        comidaRandom = Random.Range(0, comida.Length);
        maxApariciones = Random.Range(3, 10);
        index = 0;


        InvokeRepeating(nameof(aparecerComida), 0, interval);
    }
    void ReiniciarConMismosValores()
    {
        panelGeneral.SetActive(false);
        panelCorrecto.SetActive(false);
        panelIncorrecto.SetActive(false);


        index = 0;
        InvokeRepeating(nameof(aparecerComida), 0, interval);
    }
    void CerrarPanelVacio()
    {
        panelRespuestaVacia.SetActive(false);
    }
}

