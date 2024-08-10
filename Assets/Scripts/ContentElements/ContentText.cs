using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ContentText : MonoBehaviour, IContentElement
{
    [SerializeField] private TMP_Text text;
    public void Display(float fadeInDuration)
    {
        text.DOColor(new Color(1, 1, 1, 1), fadeInDuration);
    }

    public void Hide(float fadeOutDuration)
    {
        text.DOColor(new Color(1, 1, 1, 0), fadeOutDuration);
    }

}
