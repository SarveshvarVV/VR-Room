using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Element : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private string elementName;
    [SerializeField] private string symbol;
    [SerializeField] private string flameColor;
    [SerializeField] private GameObject particlePrefab;

    public string Symbol {get => symbol;}
    public string ElementName{get => elementName;}
    public string FlameColor{get => flameColor;}
    public GameObject ParticlePrefab{get => particlePrefab;}

}
