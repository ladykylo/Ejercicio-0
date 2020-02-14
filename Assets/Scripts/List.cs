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
        listaSilvia.Add("YAMERO");
        listaSilvia.Add("UWU");
        listaSilvia.Add("TEME");
        listaSilvia.Add("BAKA");
        listaSilvia.Add("Are Are");
        listaSilvia.Add("Bet Su Ni");

        Debug.Log(listaSilvia [4]);
        textoLista.text = listaSilvia[4];

        InvokeRepeating("MostrarTextoAleatorio", 0f, 3f);
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
