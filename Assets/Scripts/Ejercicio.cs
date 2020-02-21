using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ist<Vector2> listaDeVectores = new List<Vector2>();

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
