using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private PauseMenu pause;
    private Vector2 targetPos;
    public Manager manager;
    public float moveSpeed;
    public float movement;
    public GameObject effect;
    public GameObject score;
    public GameObject sprite1;
    public GameObject sprite2;
    public GameObject sprite3;
    public GameObject sprite4;
    public GameObject sprite5;
    public GameObject sprite6;
    private float ScreenWidth;

void Start ()
{
    ScreenWidth = Screen.width;
}



   public void Update()
    {
        movement = Input.GetAxisRaw("Horizontal");

    }
    private void FixedUpdate()
    {
       
        
        transform.RotateAround(Vector3.zero, Vector3.forward, movement * Time.fixedDeltaTime * -moveSpeed);
        
    }
    private void OnTriggerEnter2D(Collider2D collision)

    {

        FindObjectOfType<Manager>().TryAgain();
        Destroy(gameObject);
  
    }

    public void OnDestroy()
    {
        FindObjectOfType<Manager>().Spawn();
        Instantiate(effect, transform.position, Quaternion.identity);
        sprite4.SetActive(false);
        sprite1.SetActive(false);
        sprite2.SetActive(false);
        sprite3.SetActive(false);
        sprite5.SetActive(false);
        sprite6.SetActive(false);
    }

}



   

     
