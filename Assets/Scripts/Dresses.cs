using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dresses : MonoBehaviour
{
    [SerializeField] private List<GameObject> dresses;
    [SerializeField] private GameObject dress;
    [SerializeField] private Transform pos;

    private void Start()
    {
        Instantiate(dress, pos);
        Instantiate(dress, pos);
        Instantiate(dress, pos);
        Instantiate(dress, pos);
        Instantiate(dress, pos);
    }
}
