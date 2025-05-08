using UnityEngine;

public class PlantaNotaApolo : MonoBehaviour
{
    
    public string notaPlanta;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Colisión detectada entre " + gameObject.name + " y " + collision.gameObject.name);
            AudioManager.Instance.Play(notaPlanta);
            // Esta linea de código iba antes con un método normal, pero como ahora es Coroutine se cambia por
            // StartCoroutine(AudioManager.Instance.Play(notaPlanta));
        }

    }
}
