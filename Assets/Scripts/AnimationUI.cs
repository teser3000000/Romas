using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimationUI : MonoBehaviour
{
    [SerializeField] private CanvasGroup background;
    [SerializeField] private GameObject zaglishka;

    private void Start()
    {
        StartCoroutine(AnimationEnd());
        
        StartCoroutine(AnimationStart());
        
        StartCoroutine(OffElement());
        
    }

    private void Update()
    {
        if (background.alpha == 1)
        {
            zaglishka.SetActive(false);
        }
    }

    private IEnumerator AnimationStart()
    {
        yield return new WaitForSeconds(3);
        background.LeanAlpha(0, 0.5f);
    }
    
    private IEnumerator AnimationEnd()
    {
        yield return new WaitForSeconds(1);
        background.LeanAlpha(1, 0.5f);
    }
    private IEnumerator OffElement()
    {
        yield return new WaitForSeconds(3.4f);
        gameObject.SetActive(false);
    }
    
    
}
