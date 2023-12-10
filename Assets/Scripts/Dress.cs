using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Dress : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI nameDress;
    [SerializeField] private TextMeshProUGUI priceDress;
    
    [SerializeField] private GameObject buttonAddToCart;
    [SerializeField] private GameObject buttonMakingAnOrder;
    [SerializeField] private GameObject buttonPrim;

    [SerializeField] private GameObject formRegister;
    [SerializeField] private GameObject formDecoration;
    [SerializeField] private GameObject openingAnElement;
    [SerializeField] private GameObject versionOne;

    [SerializeField] private User user;
    [SerializeField] private Basket basket;
    [SerializeField] private AnOpenElement _anOpenElement;

    [SerializeField] private float price;
    [SerializeField] private string name;
    
    private int _value = 0;
    private bool _inBasket;

    private void Start()
    {
        /*nameDress.text = name;
        priceDress.text = price.ToString();*/
    }

    public void AddInBasket()
    {
        if (_inBasket)
        {
            FormPrimOpen();
        }
        else
        {
            basket.DeleteArray();
                    
            buttonAddToCart.SetActive(false);
            buttonMakingAnOrder.SetActive(true);
                    
            _inBasket = true;
            user.AddInBasketArray(gameObject);
            
            basket.OutputToTheScreen();
            Debug.Log("EXL");
        }
        
    }

    public void FormPrimOpen()
    {
        if (!user.IsAuthorized)
        {
            FormRegisterOpen();
        }
        else
        {
            FormDecorationOpen();
        }
    }
    
    public void FormRegisterOpen()
    {
        formRegister.SetActive(true);
    }
    
    public void FormDecorationOpen()
    {
        _anOpenElement.openElement.Clear();
        openingAnElement.SetActive(true);
        versionOne.SetActive(false);
        _anOpenElement.openElement.Add(gameObject);
        formDecoration.SetActive(true);
    }

    public void OpeningDress()
    {
        openingAnElement.SetActive(true);
    }

    public void CloseDress()
    {
        openingAnElement.SetActive(false);
    }
}
