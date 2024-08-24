using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class ContentButton : MonoBehaviour, IContentElement
{
    public bool isInteractable { get; private set; }

    [Header("Button componenets")]
    [SerializeField] private Button button; 
    [SerializeField] private ContentImage buttonImg;
    [SerializeField] private ContentText buttonTxt;

    public void Display(float fadeInDuration)
    {
        button.interactable = true;
        if (buttonImg != null) buttonImg.Display(fadeInDuration);
        if (buttonTxt != null) buttonTxt.Display(fadeInDuration);
    }

    public void Hide(float fadeOutDuration)
    {
        button.interactable = false;
        if (buttonImg != null) buttonImg.Hide(fadeOutDuration);
        if (buttonTxt != null) buttonTxt.Hide(fadeOutDuration);
    }
}
