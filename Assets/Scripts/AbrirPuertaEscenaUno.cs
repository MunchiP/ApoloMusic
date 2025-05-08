using System;
using UnityEngine;

public class AbrirPuertaEscenaUno : MonoBehaviour
{
     public PosicionarPilar posicionarPilar;
     public PosicionarPilar1 posicionarPilarDos;
     public CreacionPlanta creacionPlanta;
    public Animator anim;
    private String nombreResultante;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        nombreResultante = "";
        anim.SetBool("eso",false);
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
        if(nombreResultante == "M6M8"){
            anim.SetBool("eso",true);
            Debug.Log("eso");
        }
    }
}
