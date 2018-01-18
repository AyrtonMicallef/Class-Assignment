using System.Collections;
using System.Collections.Generic;

using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class Scoreboard_Controller3 : MonoBehaviour
{
    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void LoadLevel(string levelName)
    {
        print("Loading level " + levelName);

        //loads the scene named levelName
        SceneManager.LoadScene(levelName);
    }

    public static Scoreboard_Controller3 instance;

    public Text playerOneScoreText;
    public Text playerTwoScoreText;

    public int playerOneScore;
    public int playerTwoScore;
    public static int scoreP1 = 0;
    public static int scoreP2 = 0;

    // Use this for initialization
    void Start()
    {

        instance = this;

        playerOneScore = playerTwoScore = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GivePlayerOneAPoint()
    {

        playerOneScore += 1;

        playerOneScoreText.text = playerOneScore.ToString();

        //Enter player 1 victory
        if (playerOneScore == 7)
        {
            LoadNextLevel();
            scoreP1 = scoreP1 + 1;
        }
    }

    public void GivePlayerTwoAPoint()
    {

        playerTwoScore += 1;

        playerTwoScoreText.text = playerTwoScore.ToString();

        //Enter player 2 victory
        if (playerTwoScore == 7)
        {
            LoadNextLevel();
            scoreP2 = scoreP1 + 1;
        }
    }

}