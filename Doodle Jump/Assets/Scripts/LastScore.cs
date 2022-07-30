using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LastScore : MonoBehaviour
{
    public Text EndScore;
    Score ss; 
    // Start is called before the first frame update
    void Start()
    {
        EndScore.text = PlayerPrefs.GetFloat("Score").ToString("0");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
