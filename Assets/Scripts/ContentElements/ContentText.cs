using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ContentText : MonoBehaviour, IContentElement
{
    [SerializeField] private TMP_Text text;

    private Color initialColor;
    private Color initialColorHide;

    private void Start()
    {
        if (text == null) throw new Exception("image is null in ContentImage");
        initialColor = text.color;
        initialColorHide = initialColor;
        initialColorHide.a = 0;
    }

    public void Display(float fadeInDuration)
    {
        text.DOColor(initialColor, fadeInDuration);
    }

    public void Hide(float fadeOutDuration)
    {
        text.DOColor(initialColorHide, fadeOutDuration);
    }

}
