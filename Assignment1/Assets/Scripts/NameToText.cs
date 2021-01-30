using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NameToText : MonoBehaviour
{
    public InputField InputFieldUI;
    private Text NameValue;

    void Start()
    {
        NameValue = GetComponent<Text>();
        DisplayName();
    }

    public void DisplayName()
    {
        string Name = "" + InputFieldUI.text;
        NameValue.text = Name;
    }
}