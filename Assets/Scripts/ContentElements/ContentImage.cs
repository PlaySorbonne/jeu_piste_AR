using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContentImage : MonoBehaviour, IContentElement
{
    [SerializeField] private Image image;
    public void Display(float fadeInDuration)
    {
        image.DOColor(new Color(1, 1, 1, 1), fadeInDuration);
    }

    public void Hide(float fadeOutDuration)
    {
        image.DOColor(new Color(1, 1, 1, 0), fadeOutDuration);
    }
}
