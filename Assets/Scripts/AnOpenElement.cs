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
            GameObject obj = Instantiate(openElement[i].gameObject, pos);
            /*obj.GetComponent<Dress>().versionOne.SetActive(true);
            obj.GetComponent<Dress>().versionSecond.SetActive(false);*/
        }
    }
    
    public void DeleteArray()
    {
        openElement.Clear();
        while (transform.childCount > 0) {
            DestroyImmediate(transform.GetChild(0).gameObject);
        }
    }
}
