using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour { 
public GameObject Doodler;
public GameObject    MainCamera; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (MainCamera.transform.position.y > Doodler.transform.position.y+50)
        {
            
            Debug.Log("Destroyed");
        }  
    }
}

