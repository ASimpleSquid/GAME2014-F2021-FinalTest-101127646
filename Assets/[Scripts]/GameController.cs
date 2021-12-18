///////////////////////////////
/// GameController.cs
/// Justin Dela Cruz
/// 101127646
/// Last Modified: 2021-12-17
/// This .cs file helps the bullets and moving platforms know where to go
/// GAME2014 - Final
//////////////////////////////

using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [Header("Bullet Related")]
    public int MaxBullets;
    public BulletType enemyBulletType;
    public BulletType playerBulletType;

    [Header("Moving Platforms")] 
    public List<MovingPlatformController> movingPlatforms;

    // Start is called before the first frame update
    void Start()
    {
        movingPlatforms = FindObjectsOfType<MovingPlatformController>().ToList();


        // Kickoff the BulletManager
        BulletManager.Instance().Init(MaxBullets, enemyBulletType, playerBulletType);
    }

    public void ResetAllPlatforms()
    {
        foreach (var platform in movingPlatforms)
        {
            platform.Reset();
        }
    }

}
