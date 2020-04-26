using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class KeypadPanel : MonoBehaviour
{
    [SerializeField]
    Text KeypadText;

    string KeypadValue = "";


    // Update is called once per frame
    void Update()
    {
        KeypadText.text = KeypadValue;

        if (KeypadValue == "1839")
        {
            TriggerEnterKeypad.DoorIsOpen = true;
        }

        if (KeypadValue.Length >= 4)
        {
            KeypadValue = "";
        }

    }
    public void AddDigit(string digit)
    {
        KeypadValue += digit;
    }
}