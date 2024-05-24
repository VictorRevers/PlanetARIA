using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "NewAstro", menuName = "Astro")]
public class Astro : ScriptableObject
{
    public string name;
    public string description;
    public Sprite photo;
    public Material material;
}
