using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AchievementSaver : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI ach1;
    [SerializeField] TextMeshProUGUI ach2;
    [SerializeField] TextMeshProUGUI ach3;
    [SerializeField] TextMeshProUGUI ach4;
    [SerializeField] TextMeshProUGUI ach5;
    [SerializeField] TextMeshProUGUI ach6;
    [SerializeField] TextMeshProUGUI ach7;

    // Start is called before the first frame update
    void Start()
    {
        ach1.text = "Total Coins Collected: " + ScoreSaver.score.totalCoinsEarned.ToString(); //done
        ach2.text = "Farthest Ran: " + ScoreSaver.score.topScore.ToString(); //done
        ach3.text = "Times Jumped: " + ScoreSaver.score.timesJumped.ToString();//done
        ach4.text = "Games Played: " + ScoreSaver.score.gamesPlayed.ToString();//done
        ach5.text = "Lowest Ran: " + ScoreSaver.score.lowestRan.ToString();//done
        ach6.text = "Hats Owned: " + ScoreSaver.score.hatsOwned.ToString() + "/7";
        ach7.text = "Abilities Owned: " + ScoreSaver.score.abilitiesOwned.ToString() + "/4";
    }


}
