using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SiguienteContenedores : MonoBehaviour {

    public GameObject[] fotos;
    public int numero;


    public void Continuar(int valor)
    {
        numero += valor;
        if (numero >= fotos.Length)
        {
            numero = 0;
        }
        if (numero < 0)
        {
            numero = fotos.Length-1;
        }
        for (int i = 0; i < fotos.Length; i++)
        {
            fotos[i].SetActive(false);
        }

        fotos[numero].SetActive(true);

    }

}
