using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContentSlider : MonoBehaviour, IContentElement
{
    [SerializeField] private Slider slider;
    [SerializeField] private ContentImage backgroundImg;
    [SerializeField] private ContentImage fillImg;
    [SerializeField] private ContentImage knobImg;

    
    public void Display(float fadeInDuration)
    {
        backgroundImg.Display(fadeInDuration);
        fillImg.Display(fadeInDuration);
        knobImg.Display(fadeInDuration);
        
    }

    public void Hide(float fadeOutDuration)
    {
        backgroundImg.Hide(fadeOutDuration);
        fillImg.Hide(fadeOutDuration);
        knobImg.Hide(fadeOutDuration);
    }

    public float GetSliderValue()
    {
        return slider.value;
    }

    public void SetSliderValue(float newValue)
    {
        slider.value = newValue;
    }
}
