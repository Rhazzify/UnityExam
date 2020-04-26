using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class KeyPadRoom2 : MonoBehaviour
{
    [SerializeField]
    Text KeypadText;

    string KeypadValue = "";


    // Update is called once per frame
    void Update()
    {
        KeypadText.text = KeypadValue;

        if (KeypadValue == "8735")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
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
