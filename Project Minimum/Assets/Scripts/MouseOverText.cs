using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class MouseOverText : MonoBehaviour
{

    public string objectName;
    public Text labelText;
    public GameObject MouseOverTextUI;
    public float fadeTime;
    //private bool displayLabel;

    /*
    void Update()
    {
        FadeText();
    }
    */
        
    void OnMouseOver()
    {
        //displayLabel = true;
        labelText.text = objectName;
        MouseOverTextUI.SetActive(true);
    }

    void OnMouseExit()
    {
        //displayLabel = false;
        MouseOverTextUI.SetActive(true);
    }

    /*
    void FadeText ()
    {
        if (displayLabel)
        {
            labelText.text = objectName;
            labelText.color = Color.Lerp(labelText.color, Color.white, fadeTime * Time.deltaTime);
        }
        else
        {
            labelText.color = Color.Lerp(labelText.color, Color.clear, fadeTime * Time.deltaTime);
        }

    }
    */


}