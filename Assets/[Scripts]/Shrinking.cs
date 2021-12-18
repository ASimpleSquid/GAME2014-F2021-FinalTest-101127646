///////////////////////////////
/// Shrinking.cs
/// Justin Dela Cruz
/// 101127646
/// Last Modified: 2021-12-17
/// This .cs file helps the shrink Platforms Function
/// GAME2014 - Final
//////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shrinking : MonoBehaviour
{
    public float changespeed = 1;
    Rigidbody2D rb;
    Vector3 temp;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // To Constantly Shrink The Platform until is despawns
            Invoke("ShrinkPlatform", 0.2f);
            Invoke("ShrinkPlatform", 0.2f);
            Invoke("ShrinkPlatform", 0.2f);
            Invoke("ShrinkPlatform", 0.2f);
            Invoke("ShrinkPlatform", 0.2f);
            Invoke("ShrinkPlatform", 0.2f);
            Invoke("ShrinkPlatform", 0.2f);
            Invoke("ShrinkPlatform", 0.2f);
            Invoke("ShrinkPlatform", 0.2f);
            Invoke("ShrinkPlatform", 0.2f);
            Destroy(gameObject, 2f);
        }
    }

    void ShrinkPlatform()
    {
        temp = transform.localScale;
        temp.x -= 2f * changespeed * Time.deltaTime;
        temp.y -= 2f * changespeed * Time.deltaTime;
        transform.localScale = temp;
    }
}
