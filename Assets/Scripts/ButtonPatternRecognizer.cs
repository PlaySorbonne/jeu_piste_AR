using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButtonPatternRecognizer : MonoBehaviour
{
    [SerializeField] private string pattern ="1122";
    [SerializeField] private UnityEvent OnHalfSequence; 
    [SerializeField] private UnityEvent OnSequenceComplete; 

    private int patternLength;
    private int patternPtr = 0;

    private void Start()
    {
        patternLength = pattern.Length;
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

        if (patternPtr >= patternLength / 2)
        {
            //Half sequence indice
            OnHalfSequence.Invoke(); 
        }

        if (patternPtr >= patternLength)
        {
            //Completed sequence
            OnSequenceComplete.Invoke(); 
        }
        
    }
}
