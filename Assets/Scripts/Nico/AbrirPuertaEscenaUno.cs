using System;
using UnityEngine;

public class AbrirPuertaEscenaUno : MonoBehaviour
{
     public PosicionarPilar posicionarPilar;
     public PosicionarPilar1 posicionarPilarDos;
     private CreacionPlanta creacionPlanta;
    public Animator anim;
    private String nombreResultante;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        creacionPlanta = GetComponent<CreacionPlanta>();
        nombreResultante = "";
        anim.SetBool("Puertapasillo",false);
    }

    // Update is called once per frame
    void Update()
    {
         if (creacionPlanta.isCreated1 && posicionarPilar.objectName != "" && posicionarPilarDos.objectName != "")
        {
            nombreResultante = posicionarPilar.objectName + posicionarPilarDos.objectName;
            AbrirPuerta();
        }
    }
    void AbrirPuerta(){
        if(nombreResultante == "M6M8" || nombreResultante == "M8M6"){
            anim.SetBool("Puertapasillo",true);
            Debug.Log("eso");
        }
    }
}
