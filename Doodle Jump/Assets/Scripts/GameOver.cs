using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameOver : MonoBehaviour { 
public GameObject Doodler;
public Text LastScore;
public GameObject MainCamera; 



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (MainCamera.transform.position.y > Doodler.transform.position.y+5)
        {
            
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            
        }  
    }

    
}

