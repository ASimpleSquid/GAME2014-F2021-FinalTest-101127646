﻿///////////////////////////////
/// SceneController.cs
/// Justin Dela Cruz
/// 101127646
/// Last Modified: 2021-12-17
/// This .cs file helps the Opossom to move
/// GAME2014 - Final
//////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float horizontalSpeed;
    public float horizontalBoundary;
    public float direction;

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    private void _Move()
    {
        transform.position += new Vector3(horizontalSpeed * direction * Time.deltaTime, 0.0f, 0.0f);
    }

    private void _CheckBounds()
    {
        // check right boundary
        if (transform.position.x >= horizontalBoundary)
        {
            direction = -1.0f;
        }

        // check left boundary
        if (transform.position.x <= -horizontalBoundary)
        {
            direction = 1.0f;
        }
    }
}
