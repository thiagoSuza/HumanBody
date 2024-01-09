using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyPart : MonoBehaviour
{
    public BodyInfoSO data;


    private void OnMouseDown()
    {
        SetInfo();


    }


    public void SetInfo()
    {
        MouseController.instance.ActiveSidePanel();
        SidePaneController.instance.ResetMaterial();
        GetComponent<SetMaterial>().FadeOff();
        SidePaneController.instance.SetTittle(gameObject.name);
        SidePaneController.instance.GetDescription(data.description);
        SidePaneController.instance.GetImagens(data.img1, data.img2);
        SidePaneController.instance.selecionedObject = gameObject;

        GetComponent<SetMaterial>().ChangeMaterial();
    }
}
