using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Normal : MonoBehaviour
{
    public Spawner spawner;
    public Player player;

    public void Ordinary()
    {

        player.moveSpeed = 300;
        player.movement = 0;
        spawner.spawnRate = 0.5f;


    }
}
