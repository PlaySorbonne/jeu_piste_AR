using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContentScrollView : MonoBehaviour, IContentElement
{

    [Header("Component parts")]
    [SerializeField] private ContentImage contentBackground; 
    [SerializeField] private ContentText text; 
    [SerializeField] private ContentImage textMask; 
    [SerializeField] private ContentImage scrollbar; 
    [SerializeField] private ContentImage scrollbarBackground; 

    public void Display(float fadeInDuration)
    {
        contentBackground.Display(fadeInDuration);
        text.Display(fadeInDuration);
        textMask.Display(fadeInDuration);
        scrollbar.Display(fadeInDuration);
        scrollbarBackground.Display(fadeInDuration);
    }

    public void Hide(float fadeOutDuration)
    {
        contentBackground.Hide(fadeOutDuration);
        text.Hide(fadeOutDuration);
        textMask.Hide(fadeOutDuration);
        scrollbar.Hide(fadeOutDuration);
        scrollbarBackground.Hide(fadeOutDuration);
    }
}
