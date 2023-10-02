using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPress : MonoBehaviour
{
    private bool canPress = true;

   
    private void OnMouseDown()
    {
        if(!canPress) return;
        canPress = false;
        gameObject.SetActive(false);
        GameManager.Instance.GetCurrentObjectShow().CheckAndShow();
    }

    public void Reset()
    {
        gameObject.SetActive(true);
        canPress = true;
    }
}
