///////////////////////////////
/// PlayerAnimationType.cs
/// Justin Dela Cruz
/// 101127646
/// Last Modified: 2021-12-17
/// This .cs file helps the player switch animations depending on an action
/// GAME2014 - Final
//////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public enum PlayerAnimationType 
{
    IDLE,
    RUN,
    JUMP,
    CROUCH
}
