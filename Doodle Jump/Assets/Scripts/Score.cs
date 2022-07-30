using UnityEngine;
using UnityEngine.UI;
using System.Collections;


 public class Score : MonoBehaviour
{
    
    public Transform player;
    public Text scoreText;
    public float scoreText1;
    public Text finalScore;
    public float finalScore1;

    
    
    

    // Update is called once per frame
    public void Update()
    {
        //finalScore1=0.0;
        scoreText1 = player.position.y;
        if(finalScore1 !< scoreText1){
            finalScore1=scoreText1; 
            scoreText.text=finalScore1.ToString("0");
            PlayerPrefs.SetFloat("Score", finalScore1);


            
        }
    }
    
}