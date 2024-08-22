using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContentAudioPlayer : MonoBehaviour, IContentElement
{
    [Header("Audio settings")]
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private bool playOnAwake; 


    [Header("Component parts")]
    [SerializeField] private ContentButton playBtn; 
    [SerializeField] private ContentButton pauseBtn; 
    [SerializeField] private ContentSlider audioSlider;
    [SerializeField] private ContentText playbackTime;
    [SerializeField] private ContentText playbackTimeMax;

    private bool hasStarted = false; 
    private bool isPlaying = false;

    #region Unity's methods

    public void Update()
    {
        // Updating the slider
        audioSlider.SetSliderValue(audioSource.time / audioSource.clip.length);
        // Updating the text 

    }

    #endregion

    public void HandlePlayButton()
    {
        PlayAudio();
        playBtn.gameObject.SetActive(false); 
        pauseBtn.gameObject.SetActive(true); 
    }

    public void HandlePauseButton()
    {
        PauseAudio();
        playBtn.gameObject.SetActive(true);
        pauseBtn.gameObject.SetActive(false);
    }

    public void PlayAudio()
    {
        if (hasStarted) audioSource.UnPause();
        else
        {
            hasStarted = true;
            audioSource.Play();
        }
        isPlaying = true; 
    }

    public void PauseAudio()
    {
        audioSource.Pause();
        isPlaying = false; 
    }

    public void HandleSlideChange(float newValue)
    {
        audioSource.time = audioSource.clip.length * newValue;
    }

    public void Display(float fadeInDuration)
    {
        playBtn.Display(fadeInDuration);
        audioSlider.Display(fadeInDuration);
        playbackTime.Display(fadeInDuration);
        playbackTimeMax.Display(fadeInDuration);
    }

    public void Hide(float fadeOutDuration)
    {
        try
        {
            playBtn.Hide(fadeOutDuration);
        } catch(Exception e)
        {
           
        }

        try
        {
            pauseBtn.Hide(fadeOutDuration);
        }
        catch (Exception e)
        {
            
        }

        PauseAudio();
        audioSource.time = 0;
        audioSlider.Hide(fadeOutDuration);
        playbackTime.Hide(fadeOutDuration);
        playbackTimeMax.Hide(fadeOutDuration);
    }
}
