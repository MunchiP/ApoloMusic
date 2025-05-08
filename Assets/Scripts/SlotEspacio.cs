using UnityEngine;

public class SlotEspacio : MonoBehaviour
{

    // Elemento que recibe el nombre del audio que llega
    public string audioNombreActual = "";

    // Como se hará por medio de colisiones entonces
    void OnTriggerEnter(Collider other)
    {
        PlantaNotaApolo planta = other.GetComponent<PlantaNotaApolo>();

        if (planta != null)
        {
            audioNombreActual = planta.notaPlanta;          
        }
        else
        {
            audioNombreActual = "";
        }
    }

}
