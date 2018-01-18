using System.Collections;
using System.Collections.Generic;

using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class End : MonoBehaviour {
    public Text winner;
    public Text score;
    private int Total1;
    private int Total2;



    // Use this for initialization
    void Start () {
        if(Scoreboard_Controller.scoreP1 + Scoreboard_Controller2.scoreP1 + Scoreboard_Controller3.scoreP1 > Scoreboard_Controller.scoreP2 + Scoreboard_Controller2.scoreP2 + Scoreboard_Controller3.scoreP2)
        {
            winner.text = "Player 1 is the winner!";
        }
        else
        {
            winner.text = "Player 2 is the winner!";
        }
        Total1 = Scoreboard_Controller.scoreP1 + Scoreboard_Controller2.scoreP1 + Scoreboard_Controller3.scoreP1;
        Total2 = Scoreboard_Controller.scoreP2 + Scoreboard_Controller2.scoreP2 + Scoreboard_Controller3.scoreP2;
        score.text = Total2 + " - " + Total1;


    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
