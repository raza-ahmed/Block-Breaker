using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Paddle paddle;
    private bool hasStarted = false;
    private Vector3 paddleToBallVector;
    Rigidbody2D rigid2D;

    // Start is called before the first frame update
    void Start()
    {
        paddle = GameObject.FindObjectOfType<Paddle>();
        paddleToBallVector = this.transform.position - paddle.transform.position;
     //   print(paddleToBallVector);
        //Initialize rigid2D
        rigid2D = GetComponent<Rigidbody2D>();
     //   print(hasStarted);
    }

    // Update is called once per frame
    void Update()
    {
        if (!hasStarted)
        {
            this.transform.position = paddle.transform.position + paddleToBallVector;
           // print(hasStarted);
            if (Input.GetMouseButtonDown(0))
            {
             //   print("Mouse Clicked");
                hasStarted = true;
                this.rigid2D.velocity = new Vector2(2f, 10f);
               // print(hasStarted);
            }
        }
    }
}
