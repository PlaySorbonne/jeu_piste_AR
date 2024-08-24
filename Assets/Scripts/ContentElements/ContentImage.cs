using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContentImage : MonoBehaviour, IContentElement
{
    [SerializeField] private Image image;

    private Color initialColor;
    private Color initialColorHide; 

    private void Start()
    {
        if (image == null) throw new Exception("image is null in ContentImage");
        initialColor = image.color;
        initialColorHide = initialColor;
        initialColorHide.a = 0; 
    }

    public void Display(float fadeInDuration)
    {
        image.DOColor(initialColor, fadeInDuration);
    }

    public void Hide(float fadeOutDuration)
    {
        image.DOColor(initialColorHide, fadeOutDuration);
    }
}
