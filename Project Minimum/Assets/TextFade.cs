using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextFade : MonoBehaviour
{
    public bool displayLabel;
    
    void Start()

    {
        displayLabel = false;
        GetComponent<MeshRenderer>().enabled = false;
    }


    void Update()
    {
        if (Input.GetKey(KeyCode.Tab))
            {
            displayLabel = true;
            FadeText();
        }
       else
        {
            displayLabel = false;
            FadeText();
        }
    }
        
    void FadeText ()
    {
        if (displayLabel)
        {
            GetComponent<MeshRenderer>().enabled = true;
        }
        else
        {
            GetComponent<MeshRenderer>().enabled = false;
        }

    }

}