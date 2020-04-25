using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour
{
    [SerializeField]
    public GameObject NextLvl, NextLevel;

    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(+1);
    }
}
