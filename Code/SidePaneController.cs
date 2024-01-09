using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SidePaneController : MonoBehaviour
{
    public static SidePaneController instance;


    [SerializeField]
    private Text tittle,description;

    [SerializeField]
    private Image img1,img2;

    [SerializeField]
    private GameObject[] allParts;
    
    public GameObject selecionedObject = null;


    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDisable()
    {
        ResetMaterial();
    }

    public void SetTittle(string aux)
    {
        tittle.text = aux;
    }

    public void GetDescription(string aux)
    {
        description.text = aux;
    }


    public void GetImagens(Sprite aux1, Sprite aux2)
    {
        img1.sprite = aux1;
        img2.sprite = aux2;
    }


    public void HideAll()
    {
        if(selecionedObject != null)
        {
            foreach(GameObject p in allParts)
            {
                p.SetActive(false);
            }
        }

        selecionedObject.SetActive(true);
    }


    public void Hide()
    {
        if(selecionedObject != null)
        {
            selecionedObject.SetActive(false);
        }
    }


    public void SetFade()
    {
        selecionedObject.GetComponent<SetMaterial>().FadeOn();
    }

    public void ResetMaterial()
    {
        if(selecionedObject != null)
        {
            selecionedObject.GetComponent<SetMaterial>().SetInitialMaterial();
        }
            
        
    }
}
