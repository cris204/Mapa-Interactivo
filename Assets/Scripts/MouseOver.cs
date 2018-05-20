using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MouseOver : MonoBehaviour,IPointerEnterHandler,IPointerExitHandler,IPointerClickHandler {

    public GameObject activar;
    public GameObject fotoGrande;
    public Activar botonFotos;
    public Transform posicionCentro;

    void Start()
    {
        activar.transform.position = posicionCentro.position;
        Debug.Log(activar.transform.position);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {

        activar.SetActive(true);
        botonFotos.DesactivarCositas();
        botonFotos.ActivarCositas();

    }

    public void OnPointerExit(PointerEventData eventData)
    {
        activar.SetActive(false);
        fotoGrande.SetActive(false);
        botonFotos.ActivarCositasDesactivadas();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        fotoGrande.SetActive(true);
    }


}
