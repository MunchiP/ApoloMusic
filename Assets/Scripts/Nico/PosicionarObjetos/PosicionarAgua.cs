using UnityEngine;

public class PosicionarAgua : MonoBehaviour
{
    public bool isAguaColocada = false;
     void OnTriggerEnter(Collider other)
    {
        // Solo aceptar el objeto si es agua y no tiene padre
        if (other.CompareTag("Agua") && other.transform.parent == null)
        {
            isAguaColocada = true;
            // Posicionar el objeto con el tag "Agua" en la misma posición del objeto que tiene este collider
            other.transform.position = transform.position;
            other.transform.rotation = Quaternion.identity;
            Debug.Log("Agua posicionada en la posición: " + transform.position);
        }
    }
    void OnTriggerExit(Collider other)
    {
        isAguaColocada = false;
    }
}