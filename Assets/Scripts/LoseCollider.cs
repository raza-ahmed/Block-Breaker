using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCollider : MonoBehaviour
{
    public LevelManager levelManager;

    void OnCollisionEnter2D(Collision2D collision)
    {
      //  print("Collision occured");
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
      //  print("Trigger occured");
        levelManager.LoadLevel("Win");
    }
}
