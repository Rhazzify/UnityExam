using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerLight : MonoBehaviour
{
    [SerializeField]
    public GameObject Prosjektor, Clue;

    private void OnTriggerEnter(Collider other)
    {
        Clue.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        Clue.SetActive(false);
    }
}
