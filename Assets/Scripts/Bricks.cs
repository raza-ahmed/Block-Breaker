using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bricks : MonoBehaviour
{
    public int maxHit;
    private int timesHit;
    private LevelManager levelManager;

    // Start is called before the first frame update
    void Start()
    {
        timesHit = 0;
        levelManager = GameObject.FindObjectOfType<LevelManager>();
    }

    // Update is called once per frame
    void Update()
    {
        print(timesHit);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        timesHit++;
        if (timesHit >= maxHit)
        {
            Destroy(gameObject);
        }
        else{
            maxHit--;
        }
       
    }

    void SimulateWin()
    {
        levelManager.LoadNextLevel();
    }

   
}
