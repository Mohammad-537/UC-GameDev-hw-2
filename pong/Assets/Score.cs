using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Score : MonoBehaviour
{
    //public Audio
    [SerializeField]private TextMeshProUGUI scoringUI;
    private int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoringUI.text = ("Testing "+ score);
    }
    //private void OnTriggerEnter2D(Collider2D other)
    //{

    //    //scoringUI.text = "Your new text is here";
    //    score += 1;
        
    //    transform.position = new Vector2(0, 0);
    //}
}
