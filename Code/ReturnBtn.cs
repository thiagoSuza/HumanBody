using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnBtn : MonoBehaviour
{
    [SerializeField]
    private GameObject mainPanel,videoPanel;

    
    public void ReturnToMenu()
    {
        mainPanel.SetActive(true);
        videoPanel.SetActive(false);

    }
}
