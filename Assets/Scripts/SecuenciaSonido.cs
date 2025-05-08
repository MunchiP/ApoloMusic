using System.Collections.Generic;
using UnityEngine;

//Scrip que guarda las secuencias

[CreateAssetMenu(fileName = "NuevaSecuenciaSonido", menuName = "SoundGame/Secuencia de Sonido")]
public class SecuenciaSonido : ScriptableObject
{
    // public List<string> secuencia = new List<string>(); // si la voy a llenar yo en código y no en el inspector
       public List<string> nombresSonidos;
}