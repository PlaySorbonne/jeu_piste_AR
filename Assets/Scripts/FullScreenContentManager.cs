using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullScreenContentManager : MonoBehaviour
{
    [SerializeField] private List<ContentPanel> fullScreenPanels;

    private int currentPanel = -1; // equals to -1 if none
    
    public void DisplayFullScreenPannel(int id)
    {
        fullScreenPanels[id].transform.gameObject.SetActive(true);
        fullScreenPanels[id].Display(); 
    }


}
