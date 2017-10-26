using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Information : Interactable
{

    public string information;

    public override void Interact()
    {
        base.Interact();
        TextBubble();
    }

    void TextBubble()
    {
        Debug.Log(information);
    }
}
