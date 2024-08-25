using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButtonPatternRecognizer : MonoBehaviour
{
    //[SerializeField] private ContentImage blackFilter;
    [SerializeField] private string pattern ="123";
    [SerializeField] private UnityEvent OnSequenceComplete;
    [SerializeField] private string validateQuestURL = "https://c.tenor.com/2_xeX2jkM0oAAAAd/tenor.gif";

    private int patternLength;
    private int patternPtr = 0;

    private void Start()
    {
        patternLength = pattern.Length;
        //blackFilter.Hide(0);
    }

    public void OnButtonClick(int btnId)
    {
        // Error in sequence
        if (btnId != int.Parse(pattern[patternPtr].ToString())) 
        {
            patternPtr = 0; 
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

    public void OnValidateQuest()
    {
        Application.OpenURL(validateQuestURL);
    }
}
