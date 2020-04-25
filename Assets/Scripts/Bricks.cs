using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bricks : MonoBehaviour
{
    public Sprite[] hitSprites;

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
        int maxHit = hitSprites.Length + 1;
        if (timesHit >= maxHit)
        {
            Destroy(gameObject);
        }
        else{
            SpriteUpdate();
        }
       
    }

    void SpriteUpdate()
    {
        int spriteIndex = timesHit - 1;
        this.GetComponent<SpriteRenderer>().sprite = hitSprites[spriteIndex];
    }

    void SimulateWin()
    {
        levelManager.LoadNextLevel();
    }

   
}
