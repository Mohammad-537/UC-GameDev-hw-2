using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour
{
    
    public Ball ball;
    //int y = CompareTag("Ball")
    //float y = ObjectToPull.transform.position.y;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 ballsPosition = ball.transform.position;
        
        transform.position = new Vector2(12.5f, ballsPosition.y);
        //transform.position = new Vector2(0, 0);

        //transform.position = new Vector2(0, 0);
        //if (other.CompareTag("Player1"))
        //{
        //    score += 1;
        //    scoringUI.text = "Player 1\nScore: " + score;
        //}
        //if (other.CompareTag("Player2"))
        //{
        //    score1 += 1;
        //    scoringUI2.text = "Player 2\nScore: " + score1;

        //}
    }
    
}
