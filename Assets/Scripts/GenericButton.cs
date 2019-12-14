using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public delegate void ClickDelegate();


[RequireComponent(typeof(Button), typeof(Image))]
public class GenericButton : MonoBehaviour, IPointerEnterHandler
{
    public delegate void ClickDelegate();

    ClickDelegate callback; 

    public Text textfield;

    public void Init(string caption, Sprite image = null, ClickDelegate callback = null)
    {
        textfield.text = caption;
        this.callback = callback;
        GetComponent<Image>().sprite = image;

    }

    public void Foo()
    {

    }

    public void Clicked()
    {
        if (callback != null) callback();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        GetComponent<Button>().Select();
    }

}
