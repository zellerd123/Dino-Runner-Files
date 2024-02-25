using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField] static int currentScore;
    [SerializeField] int scoreSpeed = 1;
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] TextMeshProUGUI topScoreText; 
    [SerializeField] HitpointCollider hitpointCollider;
    [SerializeField] Player player;

    // Start is called before the first frame update
    void Start()
    {
        if (GameObject.Find("Heart 1") != null)
        {
            StartCoroutine(ScoreCounter());
            currentScore = 0;
        }
        else
        {
            scoreText.text =  currentScore.ToString();
            topScoreText.text = "High Score:  \n" + ScoreSaver.score.topScore.ToString();
        }
    }

    // Update is called once per frame
    void Update()
    {
         
    }

    IEnumerator ScoreCounter()
    {
        
        scoreText.text = currentScore.ToString();
        
        yield return new WaitForSeconds(.1f);
         if (GameObject.Find("Heart 1") != null)
        {
            currentScore += scoreSpeed;
            StartCoroutine(ScoreCounter());
        }
        if (GameObject.Find("Heart 1") == null)
        {
            Debug.Log("Naw");
            if (currentScore > ScoreSaver.score.topScore)
            {
                ScoreSaver.score.topScore = currentScore;
            }
            else if(ScoreSaver.score.lowestRan == 0)
            {
                ScoreSaver.score.lowestRan = currentScore;
            }

            else if (currentScore < ScoreSaver.score.lowestRan)
            {
                ScoreSaver.score.lowestRan = currentScore;
            }
            StartCoroutine(player.DeathAnimation(20));
            Debug.Log("still not working");

        }
          
    }
    public float GetCurrentScore()
    {
        return currentScore;
    }
}
