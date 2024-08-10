using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using DG.Tweening;
using System;


public class ContentBehaviour : MonoBehaviour
{
    public Image background_img;
    public TMP_Text content_txt;


    

    #region Unity methods

    public void Start()
    {
        ContentInit(); 
    }

    #endregion

    #region Private methods

    private void ContentInit()
    {
        background_img.color = new Vector4(1, 1, 1, 0);
        content_txt.color = new Vector4(1, 1, 1, 0);
    }


    #endregion

    #region Events
    public void OnMarkerClick()
    {
        Anim_DisplayContent(); 
    }

    public void OnFullScreenClick()
    {
        Debug.Log("On Full Screen");
    }

    #endregion

    #region Animations


    private void Anim_DisplayContent()
    {
        Sequence seq = DOTween.Sequence();
        seq.Append(background_img.DOColor(new Color(1, 1, 1, .2f), 1));
        seq.Append(content_txt.DOFade(1, 1));
        seq.Play();
    }

    #endregion
}
