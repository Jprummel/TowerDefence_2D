using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class MouseInput : MonoBehaviour, IPointerClickHandler {

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("Klik op mij");
    }
}
