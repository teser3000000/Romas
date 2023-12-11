using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dresses : MonoBehaviour
{
    [SerializeField] private List<Dress> dresses;

    public void CloseDresses()
    {
        for (int i = 0; i < dresses.Count; i++)
        {
            dresses[i].CloseDress();
            dresses[i]._anOpenElement2.openElement.Clear();
            dresses[i]._anOpenElement2.DeleteArray();
        }
    }
    
}
