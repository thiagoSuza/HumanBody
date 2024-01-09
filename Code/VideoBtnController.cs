using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoBtnController : MonoBehaviour
{
    public VideoController _vc;

    [SerializeField]
    private GameObject videoPanel;


    public void Action(int numberOfIndex)
    {
        videoPanel.SetActive(true);
        _vc.SetClipIndex(numberOfIndex);
    }
}
