using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class List2 : MonoBehaviour

    {

    public Text textoLista2;
    List<string> listaComida = new List<string>() { "GALLETITAS", "COLACAO", "ESPAGUETIS", "POLLO ASADO", "CHUCHES!", "SU ALMA" };

    // Start is called before the first frame update
    void Start()
    {
        List<string> listaNombres = new List<string>();
        listaNombres.Add("Ryu");
        listaNombres.Add("Tommy");
        listaNombres.Add("Leo");
        listaNombres.Add("Kate");
        listaNombres.Add("Hare");
        listaNombres.Add("Messa");

        for (int n = 0; n < listaNombres.Count; n++)
        {

            for (int c = 0; c < listaComida.Count; c++)
            {
                Debug.Log(listaNombres[n] + " ha comprado " + listaComida[c]);
            }
        }

        List<Vector2> listaDeVectores = new List<Vector2>();

        Vector2 nuevaPosicion = new Vector2();
        nuevaPosicion.x = 0;
        nuevaPosicion.y = 0;
        listaDeVectores.Add(nuevaPosicion);

        nuevaPosicion.x = 0;
        nuevaPosicion.y = 1;
        listaDeVectores.Add(nuevaPosicion);

        nuevaPosicion.x = 1;
        nuevaPosicion.y = 0;
        listaDeVectores.Add(nuevaPosicion);

        nuevaPosicion.x = 1;
        nuevaPosicion.y = 1;
        listaDeVectores.Add(nuevaPosicion);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
