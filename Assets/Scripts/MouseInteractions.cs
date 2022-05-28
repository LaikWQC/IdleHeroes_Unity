using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class MouseInteractions : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] UnityEvent _click = null;

    public void OnPointerClick(PointerEventData eventData)
    {
        _click?.Invoke();
    }
}
