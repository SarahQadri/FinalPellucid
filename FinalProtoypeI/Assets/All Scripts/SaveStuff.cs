using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Michsky.UI.ModernUIPack;

public class SaveStuff : MonoBehaviour
{
    public InputField inputText;
    string tutorialText;

    void Start()
    {
        tutorialText = PlayerPrefs.GetString("tutorialTextKeyName");
        inputText.text = tutorialText;
    }

    public void SaveThis()
    {
        tutorialText = inputText.text;
        PlayerPrefs.SetString("tutorialTextKeyName", tutorialText);
    }
}