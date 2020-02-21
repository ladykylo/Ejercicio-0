using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class List : MonoBehaviour
{
    public Text textoLista;
    List<string> listaSilvia = new List<string>();

    // Start is called before the first frame update
    void Start()
    {
        listaSilvia.Add("TELL ME WHY");  //0
        listaSilvia.Add("Ain't nothing but a heartache");
        listaSilvia.Add("Ain't nothing but a mistake");
        listaSilvia.Add("NOW NUMBER 5"); 
        listaSilvia.Add("I never want to hear you say"); //4
        listaSilvia.Add("I want it that way");

        InvokeRepeating("MostrarTextoAleatorio", 0f, 4f);

        /*
        Debug.Log(listaSilvia [4]);        
        textoLista.text = listaSilvia[4];

        
        int cuenta = 0;

        while (cuenta <= 1000) // Para hacer un bucle que cuente hasta 1000  //Para bloquear se usa los sombolos / y *
        {
            Debug.Log(cuenta);
            cuenta++;
        }
        */

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void MostrarTextoAleatorio()
    {
        int tamagnoLista = listaSilvia.Count;
        int random = Random.Range(0, tamagnoLista);
        Debug.Log(tamagnoLista);
        textoLista.text = listaSilvia[random].ToString();
    }
}
