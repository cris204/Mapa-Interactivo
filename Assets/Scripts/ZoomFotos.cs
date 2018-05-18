using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ZoomFotos : MonoBehaviour
{

    public GameObject imagenZoom;
    public GameObject imagenAtras;
    public bool zoom;

    public void Zoom()
    {
        if (!zoom)
        {
            imagenZoom.SetActive(true);
            imagenAtras.SetActive(true);
            zoom = true;
        }
        else
        {
            imagenAtras.SetActive(false);
            imagenZoom.SetActive(false);
            zoom = false;
        }
    }
    


}
