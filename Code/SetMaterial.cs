using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetMaterial : MonoBehaviour
{
    [SerializeField]
    private Material _default, _green;

    [SerializeField] 
    private Renderer _renderer;

    // Start is called before the first frame update
    void Start()
    {
        _green =  GetComponent<BodyPart>().data.material;
        _renderer = GetComponent<Renderer>();
        _default = _renderer.material;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeMaterial()
    {
        _renderer.material = _green;
    }

    public void FadeOn()
    {
        _green.color = new Color(_green.color.r, _green.color.g, _green.color.b,0.15f);
        
    }

    public void FadeOff()
    {
        _green.color = new Color(_green.color.r, _green.color.g, _green.color.b, 1f);

    }

    public void SetInitialMaterial()
    {
        _renderer.material = _default;
    }
}
