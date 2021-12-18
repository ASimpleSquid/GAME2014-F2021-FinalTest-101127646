///////////////////////////////
/// CheckPointController.cs
/// Justin Dela Cruz
/// 101127646
/// Last Modified: 2021-12-17
/// This .cs file helps the player respawn if falling
/// into a death barrier or dying
/// GAME2014 - Final
//////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointController : MonoBehaviour
{
    public Transform spawnPoint;
    public PlayerBehaviour player;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            player.spawnPoint = spawnPoint;
        }
    }
}
