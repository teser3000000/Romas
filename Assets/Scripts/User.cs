using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class User : MonoBehaviour
{
    [SerializeField] public List<GameObject> basket;
    [SerializeField] public List<Dress> basketDreesArray;   
    [SerializeField] public GameObject formRegister;

    public bool IsAuthorized
    {
        get { return _isAuthorized; }
        set {_isAuthorized = value;}
    }
    
    [SerializeField] private bool _isAuthorized;
    
    public void AddInBasketArray(GameObject obj)
    {
        basket.Add(obj);
    }

    public void CloseElementArrayInBasket()
    {
        for (int i = 0; i < basket.Count; i++)
        {
            /*if (basket[i].GetComponent<Dress>().linkOnPrefab != null) */
                basket[i].GetComponent<Dress>().CloseBasketElement();
            Debug.Log(12222);
        }
    }
    
    /*public void Registration()
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
    }*/
}
