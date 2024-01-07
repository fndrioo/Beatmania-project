using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public bool startPlaying;

    public BeastScroller theBS;

    public int currentScore;
    public int scorePerNote = 100;
    public static GameManager instance;

    public Text Score;


    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        Score.text = "Score: 0";
    }

    // Update is called once per frame
    void Update()
    {
        if(!startPlaying)
        {
            if(Input.anyKeyDown)
            {
                startPlaying = true;
                
            }
        }
    }

    public void NoteHit()
    {
        Debug.Log("Hit On Time");

        currentScore += scorePerNote;
        Score.text = "Score: " + currentScore;
    }
    public void NoteMissed()
    {
        Debug.Log("MissedNote");
        scorePerNote = 0;
    }


}   
