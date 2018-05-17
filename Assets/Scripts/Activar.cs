using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activar : MonoBehaviour {

    public GameObject[] activar;
    public GameObject[] desactivar;

    
    public void ActivarCositas()
    {
        for (int i = 0; i < activar.Length; i++)
        {
            activar[i].SetActive(true);
        }
    }

    public void DesactivarCositas()
    {
        for (int i = 0; i < desactivar.Length; i++)
        {
            desactivar[i].SetActive(false);
        }
    }

}
