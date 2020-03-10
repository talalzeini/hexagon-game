using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class blue : MonoBehaviour
{
   
    public void BLevels()
    {
        SceneManager.LoadScene("BLevels");
    }
    public void BScore()
    {
        SceneManager.LoadScene("BScore");
    }

    public void B366()
    {
        SceneManager.LoadScene("368");
        Time.timeScale = 1f;

    }
    public void BThemes()
    {
        SceneManager.LoadScene("BThemes");
    }
    public void BSettings()
    {
        SceneManager.LoadScene("BSettings");
    }
    public void BMenu()
    {
        SceneManager.LoadScene("BMenu");
    }
}
