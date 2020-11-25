using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextSaver : MonoBehaviour
{
    public string data;
    public string data1;
    public GameObject inputField;
    public GameObject textDisplay;
    public GameObject textDisplay1;
    public GameObject input;


    public void DataDisplay()
    {
        //data = inputField.GetComponent<Text>().text;
        data1 = input.GetComponent<TextMeshProUGUI>().text;

       // textDisplay.GetComponent<Text>().text = data;
        textDisplay1.GetComponent<Text>().text = data1;
    }
}
