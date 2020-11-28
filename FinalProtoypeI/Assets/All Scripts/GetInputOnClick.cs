using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class GetInputOnClick : MonoBehaviour
{
    public Button btnClick;
    public InputField inputUser;

    private void Start()
    {
        btnClick.onClick.AddListener(GetInputOnClickHandler);
    }

    public void GetInputOnClickHandler()
    {
        UnityEngine.Debug.Log("Log input");
    }
}