using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ButtonPatternRecognizer : MonoBehaviour
{
    //[SerializeField] private ContentImage blackFilter;
    [SerializeField] private RawImage glitchRawImg;
    private bool glitchActivated = false; 

    [SerializeField] private string pattern ="123";
    [SerializeField] private UnityEvent OnSequenceComplete;
    [SerializeField] private string validateQuestURL = "https://c.tenor.com/2_xeX2jkM0oAAAAd/tenor.gif";

    private int patternLength;
    private int patternPtr = 0;

    private void Start()
    {
        patternLength = pattern.Length;
        glitchRawImg.color = new Vector4(1, 1, 1, 0);
        //blackFilter.Hide(0);
    }

    public void OnButtonClick(int btnId)
    {
        if (!glitchActivated) return; 

        // Error in sequence
        if (btnId != int.Parse(pattern[patternPtr].ToString())) 
        {
            patternPtr = 0;
            glitchRawImg.color = new Vector4(1, 1, 1, 0);
            glitchActivated = false; 
            return;
        }

        //Correct sequence btn
        patternPtr++;


        if (patternPtr >= patternLength)
        {
            //Completed sequence
            OnSequenceComplete.Invoke(); 
        }
        
    }

    public void OnSecretButtonHold()
    {
        glitchRawImg.color = new Vector4(1, 1, 1, 1);
        StartCoroutine(OnGlitchEnd());
        glitchActivated = true; 
    }

    private IEnumerator OnGlitchEnd()
    {
        yield return new WaitForSeconds(2); 
        glitchRawImg.color = new Vector4(1, 1, 1, .1f);
    }

    public void OnValidateQuest()
    {
        Application.OpenURL(validateQuestURL);
    }


}
