using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scoreboard_Controller : MonoBehaviour {

    public Text pOneScoreText;
    public Text pTwoScoreText;
    public int pOneScore;
    public int pTwoScore;
    public static Scoreboard_Controller instance;

	// Use this for initialization
	void Start () {
        instance = this;
        pOneScore = pTwoScore = 0;
    }
	
	// Update is called once per frame
	void Update () {
		
	}


    public void pOneScorePoint()
    {
        pOneScore += 1;
        pOneScoreText.text = pOneScore.ToString();
        // checking win conditions
        if (pOneScore > 4)
        {
            SceneManager.LoadScene(2);
        }
    }

    public void pTwoScorePoint()
    {
        pTwoScore += 1;
        pTwoScoreText.text = pTwoScore.ToString();
        // checking win conditions
        if (pOneScore > 4)
        {
            SceneManager.LoadScene(2);
        }
    }

}
