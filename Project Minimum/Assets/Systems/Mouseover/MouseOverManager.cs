using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseOverManager : MonoBehaviour {

    public GameObject mouseOverTextUI;
    
    // Use this for initialization
	void Start ()
    {
        mouseOverTextUI.SetActive(false);
	}

    void OnMouseOver(MouseOver mouseOver)
    {
        mouseOverTextUI.SetActive(true);
    }
}
