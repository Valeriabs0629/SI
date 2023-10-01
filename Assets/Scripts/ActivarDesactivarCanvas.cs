using UnityEngine;

public class ActivarDesactivarCanvas : MonoBehaviour
{
    public GameObject canvas; // Asigna el Canvas que quieres activar/desactivar en el Inspector
    public float distanciaActivacion = 5f; // La distancia a la que se activará el Canvas

    private Camera mainCamera;
    private bool canvasActivo = false;

    private void Start()
    {
        mainCamera = Camera.main;
        canvas.SetActive(false); // Desactiva el Canvas al inicio del juego
    }

    private void Update()
    {
        // Solo activa el Canvas si aún no está activo y el objeto se acerca a la cámara
        if (!canvasActivo)
        {
            float distancia = Vector3.Distance(transform.position, mainCamera.transform.position);

            // Comprueba si la distancia es menor o igual a la distancia de activación
            if (distancia <= distanciaActivacion)
            {
                canvas.SetActive(true); // Activa el Canvas
                canvasActivo = true; // Marca el Canvas como activo
            }
        }
    }
}
