using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public float restartDelay = 1f;
    public GameObject TryAgainUI;
    public GameObject SpawnerUI;
    public void TryAgain()
    {
        TryAgainUI.SetActive(true);


    }

    public void Spawn()
    {

        SpawnerUI.SetActive(false);
    }

}




