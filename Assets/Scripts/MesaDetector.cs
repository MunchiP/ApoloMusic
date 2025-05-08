using UnityEngine;

public class MesaDetector : MonoBehaviour
{
    // Estos serán los colliders de cada uno de los slots
    public Collider colliderAgua;
    public Collider colliderMaceta1;
    public Collider colliderMaceta2;
    public Collider colliderPilar;
    public Collider colliderPilar2;

    // Método que se llama cuando un objeto entra en el Trigger (Collider)
    void OnTriggerEnter(Collider other)
    {
        // Verificar si el objeto tiene el tag "Agua" y toca el collider de agua
        if (other.CompareTag("Agua"))
        {
            if (other == colliderAgua)
            {
                Debug.Log("Agua");
            }
        }
        // Verificar si el objeto tiene el tag "Maceta" y toca el collider de maceta1
        else if (other.CompareTag("Maceta"))
        {
            if (other == colliderMaceta1)
            {
                Debug.Log("Maceta 1");
            }
            // Verificar si toca el collider de maceta2
            else if (other == colliderMaceta2)
            {
                Debug.Log("Maceta 2");
            }
            else if (other == colliderPilar)
            {
                Debug.Log("Pilar 1");
            }
            else if (other == colliderPilar2)
            {
                Debug.Log("Pilar 2");
            }
        }
    }
}
