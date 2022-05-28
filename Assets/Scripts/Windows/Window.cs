using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Window : MonoBehaviour
{
    [SerializeField] GameObject _content;
    
    public virtual void Show()
    {
        _content.SetActive(true);
    }
    public virtual void Close()
    {
        _content.SetActive(false);
    }
}
