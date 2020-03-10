
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StopGame : MonoBehaviour
{


    public GameObject pauseMenuUI;



    public void Resume()
    {

        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;

    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;

    }
}