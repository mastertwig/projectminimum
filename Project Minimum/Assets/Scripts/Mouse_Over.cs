using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Mouse_Over : MonoBehaviour
{

    public string myString;
    public Text labelText;
    public float fadeTime;
    public bool displayLabel;


    void Update()
    {
        FadeText();
    }
        
    void OnMouseOver()
    {
        displayLabel = true;
    }

    void OnMouseExit()
    {
        displayLabel = false;
    }

    void FadeText ()
    {
        if (displayLabel)
        {
            labelText.text = myString;
            labelText.color = Color.Lerp(labelText.color, Color.white, fadeTime * Time.deltaTime);
        }
        else
        {
            labelText.color = Color.Lerp(labelText.color, Color.clear, fadeTime * Time.deltaTime);
        }

    }


}