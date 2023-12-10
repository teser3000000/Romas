using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketController : MonoBehaviour
{
    [SerializeField] private GameObject basket;

    public void OpenBasket()
    {
        basket.SetActive(true);
    }

    public void CloseButton()
    {
        basket.SetActive(false);
    }
}
