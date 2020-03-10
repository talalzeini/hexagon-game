using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Easy : MonoBehaviour
{
    public Player player;
    public Spawner spawner;
    public void Easier()
    {

        player.moveSpeed = 300;
        player.movement = 0;

        spawner.spawnRate = 0.4f;





    }
}

