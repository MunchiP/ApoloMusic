using System;
using UnityEngine;

public class CreacionPlanta : MonoBehaviour
{
    public GameObject plantaDefault;
    public GameObject plantaResultanteUno;
    public PosicionarAgua posicionarAgua;
    public PosicionarMacetaUno posicionarMacetaUno;
    public PosicionarMacetaDos posicionarMacetaDos;
    private String nombreResultante;
    private bool isCreated1 = false;
    private String nombre1 = "MoradoNaranja";
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        plantaDefault.SetActive(true);
        plantaResultanteUno.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (posicionarAgua.isAguaColocada && posicionarMacetaUno.objectName != "" && posicionarMacetaDos.objectName != "")
        {
            nombreResultante = posicionarMacetaUno.objectName + posicionarMacetaDos.objectName;
            CrearPlanta();
        }

    }

    void CrearPlanta()
    {
                Debug.Log(nombreResultante);
        if (nombreResultante == nombre1 && !isCreated1)
        {
            plantaDefault.SetActive(false);
            plantaResultanteUno.SetActive(true);
            nombreResultante = "";
            isCreated1 = true;
        }
    }
}
