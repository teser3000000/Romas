using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Basket : MonoBehaviour
{
    [SerializeField] private Transform pos;
    [SerializeField] private User user;

    private void Start()
    {
        OutputToTheScreen();
    }

    public void OutputToTheScreen()
    {
        var basketUser= user.basket;
        for (int i = 0; i < basketUser.Count; i++)
        {
            Instantiate(basketUser[i].gameObject, pos);
        }
    }

    public void DeleteArray()
    {
        while (transform.childCount > 0) {
            DestroyImmediate(transform.GetChild(0).gameObject);
        }
    }
}
