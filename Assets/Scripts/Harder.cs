using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Harder : MonoBehaviour
{
    public Player player;
    public Spawner spawner;
    public void Hard()
    {

        player.moveSpeed = 300;
        player.movement = 0;

        spawner.spawnRate = 0.65f;





    }
}
