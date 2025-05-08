using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValidaSecuencia : MonoBehaviour
{
  
    //Validar si- la secuencia de elementos corresponde a la esperada
    //Guardar secuencia recibida
    //Compara con
    // Secuencia esperada : A1-A2-A3-A4-A5-A6-A7
    // Mostrar resultado

    // Obtendo la secuencia que el jugador me da
    // public List<string> secuenciaCorrecta = new List<string>();
    public AudioManager audioManager;
    public GameObject objetoPlay;
    public SlotEspacio[] espacios;

    private AudioSource audioSource;

    //Secuencias
    public SecuenciaSonido secuenciaActual;



    void Start()
    {
        audioSource = audioManager.GetComponent<AudioSource>(); 
        Debug.Log("Tamaño del array espacios: " + espacios.Length);
    }

    void OnMouseDown()
    {
        StartCoroutine(ValidaYReproduce());
    }

   private IEnumerator ValidaYReproduce(){

        Renderer colorRender = objetoPlay.GetComponent<Renderer>();
        bool esCorrecto = true;

    // Valido la secuencia        
        for (int i = 0; i < espacios.Length; i++)
        {
            string audioNombre = espacios[i].audioNombreActual;
                        Debug.Log(audioNombre);
            //reproduzco el sonido
            // audioManager.Play(audioNombre);

            yield return StartCoroutine(audioManager.Play(audioNombre));
            // yield return new WaitWhile(() => audioSource.isPlaying); 
            // float duracion = audioManager.GetClipLength(audioNombre);
            // yield return new WaitForSeconds(duracion);
            if (audioNombre != secuenciaActual.nombresSonidos[i])
            {
                        esCorrecto  = false;
                        colorRender.material.color = Color.red;
                        // break;
            }
            // Debug.Log($"Espacio {i} tiene el audio: {audioNombre}, esperando: {secuenciaCorrecta[i]}");
        }
        if (esCorrecto)
        {
                colorRender.material.color = Color.green;
        }
        yield break;
    }

    public void ResetSecuencia()
    {
        foreach (SlotEspacio slot in espacios)
        {
            slot.audioNombreActual = "";
        }
    }
}
