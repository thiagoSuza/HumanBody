using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveAndDesactiveBodyPartBtn : MonoBehaviour
{
   [SerializeField]
   private GameObject bodyPart;
    [SerializeField]
    private GameObject panel;

    [SerializeField]
    private GameObject[] pieces;


    public void OpenPanel()
    {
        panel.SetActive(true);
    }

    public void ActiveBodyPart()
    {
        bodyPart.SetActive(true);
        panel.SetActive(false);

        foreach(GameObject p in pieces)
        {
            p.SetActive(true);
        }
    }

    public void DesactiveBodyPart()
    {
        bodyPart.SetActive(false);
        panel.SetActive(false);
    }

}
