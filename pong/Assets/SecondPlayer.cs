using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondPlayer : MonoBehaviour
{
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
        //rb.velocity = new Vector2(0f, 1f);

    }
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {

            rb.velocity = Vector2.up * speed;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.velocity = Vector2.down * speed;
        }
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            rb.velocity = Vector2.up * 0;
        }
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            rb.velocity = Vector2.down * 0;
        }
    }
}