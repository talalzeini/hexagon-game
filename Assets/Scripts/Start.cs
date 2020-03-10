using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour
{
    public Player player;
    // Start is called before the first frame update
    public void StartGame()
    {
        SceneManager.LoadScene("366");
        Time.timeScale = 1f;
    }
    public void GStart()
    {
        SceneManager.LoadScene("G366");
        Time.timeScale = 1f;
    }


public void Settings()
    {
        SceneManager.LoadScene("Settings");
    }
    public void GSettings()
    {
        SceneManager.LoadScene("GSettings");
    }
    public void Difficulty()
    {
        SceneManager.LoadScene("Difficulty");
    }
    public void GLevels()
    {
        SceneManager.LoadScene("GLevels");
    }
    public void Score()
    {
        SceneManager.LoadScene("Score");
    }
public void GScore()
    {
       SceneManager.LoadScene("GScore");
    }
public void G366()
{
 SceneManager.LoadScene("367");
  Time.timeScale = 1f;

}
public void Themes()
{
 SceneManager.LoadScene("Themes");
}
public void GThemes()
{
 SceneManager.LoadScene("GThemes");
}
}

