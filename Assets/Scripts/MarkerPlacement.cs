using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MarkerPlacement : MonoBehaviour
{
    [SerializeField] private Transform markerParent;
    private Vector3 initPos; 

    [SerializeField] private Slider xSlider;
    [SerializeField] private TMP_Text xText;

    [SerializeField] private Slider ySlider;
    [SerializeField] private TMP_Text yText;

    [SerializeField] private Slider zSlider;
    [SerializeField] private TMP_Text zText;

    private void Start()
    {
        initPos = markerParent.position;
        xText.SetText("0");
        yText.SetText("0");
        zText.SetText("0");
    }

    public void OnSliderChange()
    {
        markerParent.position = initPos + new Vector3(xSlider.value, ySlider.value, zSlider.value);
        xText.SetText(xSlider.value.ToString());
        yText.SetText(ySlider.value.ToString());
        zText.SetText(zSlider.value.ToString());
    }
    
}
