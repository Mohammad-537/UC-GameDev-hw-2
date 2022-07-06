using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIEasy : MonoBehaviour
{
    public Ball ball;
    Rigidbody2D rb;
    public int speed = 10;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 ballPosition = ball.transform.position;

        if (ballPosition.y >= 1f)
        {
            rb.velocity = Vector2.up * speed;
        }
        if (ballPosition.y <= -1f)
        {
            rb.velocity = Vector2.down * speed;
        }
        //transform.position = new Vector2(12.5f, ballsPosition.y);
    }
}
