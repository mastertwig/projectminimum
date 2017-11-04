using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Ink.Runtime;

public class Dialogue : Interactable {

    public TextAsset inkJSONAsset;
    public Story story;
    public GameObject player;
    private PlayerManager playermanager;

    public GameObject dialogueCanvas;

    public Button buttonPrefab;
    public Text textPrefab;

    public GameObject textLayout;
    public GameObject buttonLayout;

    public override void Interact()
    {
        base.Interact();
        playermanager = player.GetComponent<PlayerManager>();
        playermanager.DisableMotor();
        StartStory();
    }

    void StartStory()
    {
        story = new Story(inkJSONAsset.text);
        dialogueCanvas.SetActive(true);
        RefreshView();
    }

    void RefreshView()
    {
        RemoveChildren();

        while (story.canContinue)
        {
            string text = story.ContinueMaximally();
            CreateContentView(text);
        }

        if (story.currentChoices.Count > 0)
        {
            for (int i = 0; i < story.currentChoices.Count; i++)
            {
                Choice choice = story.currentChoices[i];
                Button button = CreateChoiceView(choice.text.Trim());
                button.onClick.AddListener(delegate {
                    OnClickChoiceButton(choice);
                });
            }
        }
        else
        {
            Button choice = CreateChoiceView("Continue...");
            choice.onClick.AddListener(delegate {
                EndStory();
            });
            
        }
    }

    void OnClickChoiceButton(Choice choice)
    {
        story.ChooseChoiceIndex(choice.index);
        RefreshView();
    }

    Button CreateChoiceView(string text)
    {
        Button choice = Instantiate(buttonPrefab) as Button;
        choice.transform.SetParent(buttonLayout.transform, false);

        Text choiceText = choice.GetComponentInChildren<Text>();
        choiceText.text = text;

        return choice;
    }

    void CreateContentView(string text)
    {
        Text storyText = Instantiate(textPrefab) as Text;
        storyText.text = text;
        storyText.transform.SetParent(textLayout.transform, false);
        storyText.transform.SetSiblingIndex(0);
    }

    void RemoveChildren()
    {
        int buttonChildCount = buttonLayout.transform.childCount;
        for (int i = buttonChildCount - 1; i >= 0; --i)
        {
            GameObject.Destroy(buttonLayout.transform.GetChild(i).gameObject);
        }

        GameObject[] texts = GameObject.FindGameObjectsWithTag("DialogueText");
        for (int i = 0; i < texts.Length; i++)
        {
            Destroy(texts[i]);
        }
    }

    void EndStory()
    {
        dialogueCanvas.SetActive(false);
        playermanager.EnableMotor();
    }

}
