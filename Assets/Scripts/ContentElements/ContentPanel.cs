using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ContentPanel : SerializedMonoBehaviour, IContentElement
{   
    [SerializeField] public List<List<IContentElement>> contentElements;
    [SerializeField] private float intervalTime;
    [SerializeField] private float fadeDuration;
    private bool isDisplayed = false; 

    #region Unity's methods

    public void Start()
    {
        foreach (var elementList in contentElements)
            foreach (var element in elementList)
                element.Hide(0);
        isDisplayed = false;
        StartCoroutine(DisableGameObject(fadeDuration));
    }

    #endregion

    public void Display(float fadeInDuration)
    {
        gameObject.SetActive(true); 
        StartCoroutine(DisplayContent(fadeInDuration));
        isDisplayed = true;
    }

    public void Display()
    {
        gameObject.SetActive(true);
        StartCoroutine(DisplayContent(fadeDuration));
        isDisplayed = true; 
    }

    public void MarkerButton()
    {
        if (isDisplayed) Hide();
        else Display(); 
    }

    public IEnumerator DisplayContent(float fadeInDuration)
    {
        foreach (var elementList in contentElements)
        {
            foreach (var element in elementList)
                element.Display(fadeInDuration);

            yield return new WaitForSeconds(intervalTime);
        }
        yield return null; 
    }

    public void Hide(float fadeOutDuration)
    {
        foreach (var elementList in contentElements)
            foreach (var element in elementList)
                element.Hide(fadeOutDuration);

        isDisplayed = false;
        StartCoroutine(DisableGameObject(fadeDuration));
    }

    public void Hide()
    {
        foreach (var elementList in contentElements)
            foreach (var element in elementList)
                element.Hide(fadeDuration);

        isDisplayed = false;
        StartCoroutine(DisableGameObject(fadeDuration));
    }

    private IEnumerator DisableGameObject(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        this.gameObject.SetActive(false); 
    }
}

