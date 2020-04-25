using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bricks : MonoBehaviour
{
    public Sprite[] hitSprites;
    public static int breakableCount = 0;

    private int timesHit;
    private LevelManager levelManager;
    private bool isBreakable;

    // Start is called before the first frame update
    void Start()
    {
        isBreakable = (this.tag == "Breakable");
        if (isBreakable)
        {
            breakableCount++;
        }
        
        timesHit = 0;
        levelManager = GameObject.FindObjectOfType<LevelManager>();
    }

    // Update is called once per frame
    void Update()
    {
       // print(timesHit);
       // print(breakableCount);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
       
        if (isBreakable){
            HandleHits();
        }
    }

    void HandleHits()
    {
        timesHit++;
        int maxHit = hitSprites.Length + 1;
        if (timesHit >= maxHit){
            breakableCount--;
            levelManager.BrickDestroyed();
           // print(breakableCount);
            Destroy(gameObject);
            
        }
        else
        {
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
