using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 


public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    
    public TextMeshProUGUI ElementSymbol;
    public TextMeshProUGUI ElementName;
    public TextMeshProUGUI ElementColor;

    private static GameManager _Instance;
    public static GameManager Instance { get => _Instance; }

    private void Awake()
    {
         if(_Instance != null && _Instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _Instance = this; 
        }
    }
    void Start()
    {
        ElementSymbol.SetText("");
        ElementName.SetText("");
        ElementColor.SetText("");
    }
        
    public void ShowSelectedElement(Element element)
    {
        ElementSymbol.SetText(element.Symbol);
        ElementName.SetText(element.ElementName);
    }
        
    public void ShowElementColor(Element element)
    {
        ElementColor.SetText(element.FlameColor);
    }

    public void HideElementText()
    {
        ElementSymbol.SetText("");
        ElementName.SetText("");
        ElementColor.SetText("");   
    }
}
