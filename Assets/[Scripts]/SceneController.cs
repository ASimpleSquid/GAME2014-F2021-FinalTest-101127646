///////////////////////////////
/// SceneController.cs
/// Justin Dela Cruz
/// 101127646
/// Last Modified: 2021-12-17
/// This .cs file helps the scene Transition
/// GAME2014 - Final
//////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{


    public void OnButtonPressed()
    {
        SceneManager.LoadScene("Platformer");
    }
}
