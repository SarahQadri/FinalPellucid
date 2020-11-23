using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayAnnotate : MonoBehaviour
{
    publis string theName;
    public GameObject inputField;
    public GameObject textDisplay;

    public void StoreName()
    {
        theName = inputField.GetComponent<textDisplay>().text
            textDisplay.GetComponent<textDisplay>().text = theName;
    }
}