using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraCegar : MonoBehaviour
{
    public float distanciaUmbral = 2.0f; // La distancia a la que se activará el efecto de cegar.
    public GameObject objetoACegar; // El objeto que causará la activación/desactivación del Canvas.
    public Canvas canvas; // La referencia al componente Canvas que se asignará en el Inspector.

    private void Start()
    {
        if (canvas != null)
        {
            canvas.enabled = false; // Desactiva el Canvas al inicio.
        }
    }

    private void Update()
    {
        // Si el objeto está dentro del rango umbral, activa el Canvas.
        if (objetoACegar != null)
        {
            float distancia = Vector3.Distance(transform.position, objetoACegar.transform.position);

            if (distancia < distanciaUmbral)
            {
                if (canvas != null)
                {
                    canvas.enabled = true; // Activa el Canvas.
                }
            }
            else
            {
                if (canvas != null)
                {
                    canvas.enabled = false; // Desactiva el Canvas.
                }
            }
        }
    }
}
