using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour {

    public GameObject dialogueUI;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetMouseButtonDown(0))
            {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                BasicInkExample ink = hit.transform.GetComponent<BasicInkExample>();
                ink.StartStory();
                /*Debug.Log(hit.collider.name);
                DialogueTrigger dialogue = hit.transform.GetComponent<DialogueTrigger>();
                if (hit.transform.GetComponent<DialogueTrigger>() != null)
                {
                    dialogue.TriggerDialogue();
                }
                */
            }
        }
    }
}
