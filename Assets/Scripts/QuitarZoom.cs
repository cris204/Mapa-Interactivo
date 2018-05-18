using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class QuitarZoom : MonoBehaviour,IPointerDownHandler {

    public ZoomFotos zoom;

    public void OnPointerDown(PointerEventData eventData)
    {
        zoom.Zoom();
    }
}
