using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class User : MonoBehaviour
{
    [SerializeField] public List<GameObject> basket;
    [SerializeField] private TextMeshProUGUI numberItemsInBasket;

    [SerializeField] public Text phoneNumber;
    [SerializeField] public Text userName;

    [SerializeField] public GameObject warning;
    [SerializeField] public GameObject formRegister;

    public bool IsAuthorized
    {
        get { return _isAuthorized; }
        set {_isAuthorized = value;}
    }
    
    [SerializeField] private bool _isAuthorized;

    private void FixedUpdate()
    {
        /*int quality = basket.Count;
        if (quality == 1)
        {
            numberItemsInBasket.text = "1";
        }
        else
        {
            numberItemsInBasket.text = (basket.Count).ToString();
        }*/
    }

    public void AddInBasketArray(GameObject obj)
    {
        basket.Add(obj);
    }

    public void Registration()
    {
        if (phoneNumber.text != "" && userName.text != "")
        {
            _isAuthorized = true;   
            formRegister.SetActive(false);
        }
        else
        {
            warning.SetActive(true);
        }
    }
}
