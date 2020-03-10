using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TryAgainButton : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene("366");
    }
public void GRestart()
    {
        SceneManager.LoadScene("367");
    }


    public void Reset()
    {
       PlayerPrefs.DeleteAll();
    }
}

