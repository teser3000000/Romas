using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnOpenElement : MonoBehaviour
{
    [SerializeField] public List<GameObject> openElement;
    [SerializeField] private Transform pos;
    
    private void Start()
    {
        OutputToTheScreen();
    }

    public void OutputToTheScreen()
    {
        for (int i = 0; i < openElement.Count; i++)
        {
            Instantiate(openElement[i].gameObject, pos);
        }
    }
}
