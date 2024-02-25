using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using TMPro;

public class ScoreSaver : MonoBehaviour
{

//initializer for singleton
    public static ScoreSaver score;
//stuff saved round to round
    public int currentScore = 0;
    public int currentHearts = 3; 
//info saved after closing game
    public int topScore;
    public int currentCoinsSaved; 
    public bool hasBoughtDJ = false;
    public bool hasBoughtCDB = false;
    public bool hasBoughtGB = false;
    public bool hasBoughtMT = false;
    public bool hasBoughtHat1 = false;
    public bool hasBoughtHat2 = false;
    public bool hasBoughtHat3 = false;
    public bool hasBoughtHat4 = false;
    public bool hasBoughtHat5 = false;
    public bool hasBoughtHat6 = false;
    public bool hasBoughtTC = false;
    public bool gameOpened = false;
    public bool homePlayer = false;
    public bool hasSeenControls = false; 
    public int totalCoinsEarned = 0;
    public int timesJumped = 0;
    public int gamesPlayed = 0;
    public int lowestRan = 0;
    public int hatsOwned = 0;
    public int abilitiesOwned = 0;
    public float gameVol = 1f;
    public float buttonSpacing = 1f;
    


    void Awake()
    {
        // First do the DontDestroyOnLoad
        DontDestroyOnLoad(gameObject);

        // Now do the singleton pattern
        if (score == null)
        {
            score = this;
            Load();
        }
        else if (score != this)
        {
            Destroy(gameObject);
        }
        PlayerPrefs.SetFloat("GameVol", 1);
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    public void Save()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/PlayerInfo.dat");
        PlayerData data = new PlayerData();
        Debug.Log("current coins saved " + currentCoinsSaved);
        data.highScore = topScore;
        data.coinsSaved = currentCoinsSaved;
        data.boughtDJ = hasBoughtDJ;
        data.boughtCDB = hasBoughtCDB;
        data.boughtGB = hasBoughtGB;
        data.boughtMT = hasBoughtMT;
        data.boughtHat1 = hasBoughtHat1;
        data.boughtHat2 = hasBoughtHat2;
        data.boughtHat3 = hasBoughtHat3;
        data.boughtHat4 = hasBoughtHat4;
        data.boughtHat5 = hasBoughtHat5;
        data.boughtHat6 = hasBoughtHat6;
        data.totalCoinsEarned = totalCoinsEarned;
        data.timesJumped = timesJumped;
        data.gamesPlayed = gamesPlayed;
        data.lowestRan = lowestRan;
        data.hatsOwned = hatsOwned;
        data.abilitiesOwned = abilitiesOwned;
        data.hasBoughtTC = hasBoughtTC;
        data.hasSeenControls = hasSeenControls;
        data.gameVol = gameVol;
        data.buttonSpacing = buttonSpacing;
        bf.Serialize(file, data);
        file.Close();
    }

    public void Load()
    {
        if (File.Exists(Application.persistentDataPath + "/PlayerInfo.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/PlayerInfo.dat", FileMode.Open);
            PlayerData data = (PlayerData)bf.Deserialize(file);
            file.Close();

            topScore = data.highScore;
            currentCoinsSaved = data.coinsSaved;
             hasBoughtDJ = data.boughtDJ;
             hasBoughtCDB = data.boughtCDB;
             hasBoughtGB = data.boughtGB;
             hasBoughtMT = data.boughtMT;
            hasBoughtHat1 = data.boughtHat1;
            hasBoughtHat2 = data.boughtHat2;
            hasBoughtHat3 = data.boughtHat3;
            hasBoughtHat4 = data.boughtHat4;
            hasBoughtHat5 = data.boughtHat5;
            hasBoughtHat6 = data.boughtHat6;
            totalCoinsEarned = data.totalCoinsEarned;
            timesJumped = data.timesJumped;
            gamesPlayed = data.gamesPlayed;
            lowestRan = data.lowestRan;
            hatsOwned = data.hatsOwned;
            abilitiesOwned = data.abilitiesOwned;
            hasBoughtTC = data.hasBoughtTC;
            hasSeenControls = data.hasSeenControls;
            gameVol = data.gameVol;
            buttonSpacing = data.buttonSpacing; 
        }
    }

}




[Serializable]
class PlayerData
{
    public int highScore;
    public int coinsSaved;

    public bool boughtDJ;
    public bool boughtCDB;
    public bool boughtGB;
    public bool boughtMT;
    public bool boughtHat1;
    public bool boughtHat2;
    public bool boughtHat3;
    public bool boughtHat4;
    public bool boughtHat5;
    public bool boughtHat6;
    public bool hasBoughtTC;
    public int totalCoinsEarned = 0;
    public int timesJumped = 0;
    public int gamesPlayed = 0;
    public int lowestRan = 0;
    public int hatsOwned = 0;
    public int abilitiesOwned = 0;
    public bool hasSeenControls;
    public float gameVol;
    public float buttonSpacing = 1;
}
