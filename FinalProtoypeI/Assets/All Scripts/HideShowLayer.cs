using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HideShowLayer : MonoBehaviour
{
    public Material mater;
    public Material mater1;

    public Toggle togglebtn;
    public Toggle togglebtn1;

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

    void ChangeAlphavalue(Material mat, float alphaval)
    {
        Color oldColor = mat.color;
        Color newColor = new Color(oldColor.r, oldColor.g, oldColor.b, alphaval);
        mat.SetColor("_Color", newColor);
    }
}