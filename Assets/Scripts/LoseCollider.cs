using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCollider : MonoBehaviour
{
    private LevelManager levelManager;

    void OnCollisionEnter2D(Collision2D collision)
    {
      //  print("Collision occured");
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        //  print("Trigger occured");
        levelManager = GameObject.FindObjectOfType<LevelManager>();
        levelManager.LoadLevel("Loose");
    }
}
