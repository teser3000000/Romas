using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectedButton : MonoBehaviour
{
    private Image _image;
    private ButtonArray _buttonArray;

    private void Start()
    {
        _image = gameObject.GetComponent<Image>();
        _buttonArray = GetComponentInParent<ButtonArray>();
    }

    public void ColorButton()
    {
        _image.color = new Color(0.6980392f, 0.6980392f, 0.6980392f, 0.8352941f);
        var listTimes = _buttonArray.times;
        for (int i = 0; i < listTimes.Count; i++)
        {
            if (gameObject == listTimes[i]) continue;
            listTimes[i].GetComponent<Image>().color = new Color(0.6980392f, 0.6980392f, 0.6980392f, 0.1647059f);
        }
    }
}
