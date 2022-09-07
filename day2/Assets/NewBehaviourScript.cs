using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    int score = 0;
    public Text scoreText;
    public Text incText;
    bool shopstate = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void shop() {
        if (score >= 5) {
            score -= 5;

            scoreText.text = score.ToString();
          
            shopstate = true;
        }
    } 

    public void scoreUp() {
        score += 1;
        
        if (shopstate) {
            score += 1;
        }
        scoreText.text = score.ToString();
    }
}
