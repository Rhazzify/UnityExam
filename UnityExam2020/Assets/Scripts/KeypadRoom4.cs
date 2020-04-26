using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class KeypadRoom4 : MonoBehaviour
{
    [SerializeField]
    Text KeypadText;

    string KeypadValue = "";


    // Update is called once per frame
    void Update()
    {
        KeypadText.text = KeypadValue;

        if (KeypadValue == "9371")
        {
            TriggerEnterKeypad.DoorIsOpen = true;
            SceneManager.LoadScene(+1);
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