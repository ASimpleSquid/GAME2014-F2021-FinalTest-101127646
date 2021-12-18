///////////////////////////////
/// BulletType.cs
/// Justin Dela Cruz
/// 101127646
/// Last Modified: 2021-12-17
/// This .cs file helps pool multple kinds of bullets
/// for the Enemies and Player
/// GAME2014 - Final
//////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public enum BulletType
{
    REGULAR,
    FAT,
    PULSING,
    RANDOM,
    ACORN
}
