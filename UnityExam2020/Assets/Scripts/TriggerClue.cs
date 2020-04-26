using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerClue : MonoBehaviour
{
    [SerializeField]
    public GameObject Clue, Number;

    private void OnTriggerEnter(Collider other)
    {
        Clue.SetActive(true);
        Number.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        Clue.SetActive(false);
    }
}
