using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{

    static MusicPlayer instance = null;

    void Awake()
    {
       // Debug.Log("Music Player is Awake" +GetInstanceID());
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            GameObject.DontDestroyOnLoad(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
     //   Debug.Log("Music Player is Start" + GetInstanceID());
        
    }
    
    // Update is called once per frame
    void Update()
    {
      // Debug.Log("Music Player is Update" + GetInstanceID());
    }
}
