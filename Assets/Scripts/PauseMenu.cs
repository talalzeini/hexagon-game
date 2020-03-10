using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{ 
    public GameObject pauseMenuUI;

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;


    }
}
