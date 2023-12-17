using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SharedArray : MonoBehaviour
{
    [SerializeField] public List<GameObject> array;
    
    public void CloseDresses()
    {
        for (int i = 0; i < array.Count; i++)
        {
            array[i].GetComponent<Dress>().CloseDress();
            array[i].GetComponent<Dress>()._anOpenElement2.openElement.Clear();
            array[i].GetComponent<Dress>()._anOpenElement2.DeleteArray();
        }
    }
}
