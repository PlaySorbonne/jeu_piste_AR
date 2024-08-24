using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public interface IContentElement
{
    public void Display(float fadeInDuration);
    public void Hide(float fadeOutDuration);
}

