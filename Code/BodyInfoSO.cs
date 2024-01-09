using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Part",menuName ="SO/BodyPart")]
public class BodyInfoSO : ScriptableObject
{
    public string description;
    public Sprite img1, img2;

    public Material material;
}
