using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{
    public float spawnRate = 0.5f;
    public GameObject[] hexagons;
    private float nextTimeToSpawn;
    public int score;
    public Text scoreText;
    public Text scoreText1;
    public Manager manager;
    public int highscore;
    public Text highscoretext;
    public Player player;
    

    public void Start()
    {
        highscoretext.text = PlayerPrefs.GetInt("score", 0).ToString();
      
    }

    public void Update()
    {
        if (Time.time >= nextTimeToSpawn)
        {
            int rand = UnityEngine.Random.Range(0, 20);
            Instantiate(hexagons[rand], Vector3.zero, Quaternion.identity);
            nextTimeToSpawn = Time.time + 1f / spawnRate;
        }
        highscore = (int)score;
        scoreText.text = highscore.ToString();
        if (PlayerPrefs.GetInt("score") <= highscore)
        {
            PlayerPrefs.SetInt("score", highscore);
            highscoretext.text = PlayerPrefs.GetInt("score").ToString();
        }
    }

        public void AddScore()
    {
            score++;
            scoreText.text = score.ToString();
            scoreText1.text = score.ToString();
    }
    }


    
