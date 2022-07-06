using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Ball : MonoBehaviour
{
    Rigidbody2D rb;
    private int score;
    private int score1;
    
    [SerializeField] private TextMeshProUGUI scoringUI;
    [SerializeField] private TextMeshProUGUI scoringUI2;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(5f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        //scoringUI.text = "Your new text is here";
        
        
        transform.position = new Vector2(0, 0);
        if (other.CompareTag("Player1"))
        {
            score += 1;
            scoringUI.text = "Player 2\nScore: "+ score;
        }
        if (other.CompareTag("Player2"))
        {
            score1 += 1;
            scoringUI2.text = "Player 1\nScore: " + score1;

        }

    }
}
