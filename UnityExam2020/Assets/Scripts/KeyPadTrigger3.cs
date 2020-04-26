using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPadTrigger3 : MonoBehaviour
{
    [SerializeField]
    public GameObject KeypadUi;

    private void Update()
    {

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
