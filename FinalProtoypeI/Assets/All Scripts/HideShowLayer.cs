using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Michsky.UI.ModernUIPack;


public class HideShowLayer : MonoBehaviour
{
    public Material mater;
    public Material mater1;
    public Material mater2;
    public Material mater3;

    public Toggle togglebtn;
    public Toggle togglebtn1;
    public Toggle togglebtn2;
    public Toggle togglebtn3;

    public void TogglebtnOn()
    {
        if (togglebtn.isOn)
            ChangeAlphavalue(mater, 1f);
        else
            ChangeAlphavalue(mater, 0.01f);
    }

    public void TogglebtnOn1()
    {
        if (togglebtn1.isOn)
            ChangeAlphavalue(mater, 1f);
        else
            ChangeAlphavalue(mater, 0.01f);
    }

    public void TogglebtnOn2()
    {
        if (togglebtn2.isOn)
            ChangeAlphavalue(mater, 1f);
        else
            ChangeAlphavalue(mater, 0.01f);
    }

    public void TogglebtnOn3()
    {
        if (togglebtn3.isOn)
            ChangeAlphavalue(mater, 1f);
        else
            ChangeAlphavalue(mater, 0.01f);
    }

    void ChangeAlphavalue(Material mat, float alphaval)
    {
        Color oldColor = mat.color;
        Color newColor = new Color(oldColor.r, oldColor.g, oldColor.b, alphaval);
        mat.SetColor("_Color", newColor);
    }
}