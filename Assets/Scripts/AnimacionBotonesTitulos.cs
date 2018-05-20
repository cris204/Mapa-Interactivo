﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class AnimacionBotonesTitulos : MonoBehaviour,IPointerEnterHandler,IPointerExitHandler,IPointerClickHandler {

    public int id;
    public Animator anim;
    public bool inicio;

    void Awake()
    {
        anim = GetComponent<Animator>();
        anim.SetBool("Entrar", inicio);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        for (int i = 0; i < Manager.Instance.Selecionado.Length; i++)
        {
            Manager.Instance.Selecionado[i] = false;
        }
        Manager.Instance.Volver();
        anim.SetBool("Entrar", true);
        Manager.Instance.Selecionado[id] = true;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        anim.SetBool("Entrar", true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {

        if (!Manager.Instance.Selecionado[id])
        {
            anim.SetBool("Entrar", false);
        }
    }
}
