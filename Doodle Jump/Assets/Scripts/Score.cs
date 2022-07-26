using UnityEngine;
using UnityEngine.UI;


public class Scores : MonoBehaviour
{

    public Transform player;
    public Text scoreText;
    public float score;
    public float currentScore;
    

    // Update is called once per frame
    public void Update()
    {
        currentScore = 0;
        scoreText.text = currentScore.ToString("0");
        score = player.position.y;

        if(score > currentScore)
        {
            score = currentScore;
            

        }
        else
        {
            currentScore = currentScore;
        }
        
    }
}