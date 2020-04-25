using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEnterKeypad : MonoBehaviour
{
    [SerializeField]
    public GameObject KeypadUi, Door;

    public static bool DoorIsOpen = false;



 
    private void Update()
    {
        if (DoorIsOpen)
        {
            Door.SetActive(false);
            KeypadUi.SetActive(false);
        }
   

    }
    void OnTriggerEnter(Collider other)
    {

        KeypadUi.SetActive(true);

    }

    void OnTriggerExit(Collider other)
    {
        KeypadUi.SetActive(false);
    }
}
