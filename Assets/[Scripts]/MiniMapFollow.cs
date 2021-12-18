///////////////////////////////
/// MiniMapFollow.cs
/// Justin Dela Cruz
/// 101127646
/// Last Modified: 2021-12-17
/// This .cs file helps the Mini Map Function
/// GAME2014 - Final
//////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMapFollow : MonoBehaviour
{
    public Transform player;


    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + new Vector3(0.0f, 0.0f, -10f);
    }
}
