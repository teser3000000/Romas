using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dresses : MonoBehaviour
{
    [SerializeField] public List<Dress> dresses;
    [SerializeField] private AnOpenElement _openElement;
        

    public void CloseDresses()
    {
        for (int i = 0; i < dresses.Count; i++)
        {
            dresses[i].CloseDress();
            dresses[i]._anOpenElement2.openElement.Clear();
            dresses[i]._anOpenElement2.DeleteArray();
        }
    }

    public void DeleteContainer()
    {
        _openElement.DeleteArray();
    }
    
    
    
}
