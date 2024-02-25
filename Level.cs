using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    [SerializeField] GameObject pauseMenuUI;
    [SerializeField] GameObject optionsMenu;
    [SerializeField] GameObject creditsMenu;
    [SerializeField] AudioClip buttonClick;
    [SerializeField] GameObject movingButton;
    [SerializeField] GameObject movingButton1;
    [SerializeField] GameObject movingButton2;
    [SerializeField] GameObject movingButton3;

    private void Awake()
    {
        if (SceneManager.GetActiveScene().name == "Game")
        {
            Debug.Log("Game SCENE ACTIVE BRO");
            ButtonPosition(ScoreSaver.score.buttonSpacing);
        }
    }


    public void ResetProgress()
    {
        ScoreSaver.score.currentCoinsSaved = 0;
        ScoreSaver.score.topScore = 0;
        ScoreSaver.score.hasBoughtDJ = false;
        ScoreSaver.score.hasBoughtGB = false;
        ScoreSaver.score.hasBoughtMT = false;
        ScoreSaver.score.hasBoughtCDB = false;
        ScoreSaver.score.hasBoughtHat1 = false;
        ScoreSaver.score.hasBoughtHat2 = false;
        ScoreSaver.score.hasBoughtHat3 = false;
        ScoreSaver.score.hasBoughtHat4 = false;
        ScoreSaver.score.hasBoughtHat5 = false;
        ScoreSaver.score.hasBoughtHat6 = false;
        ScoreSaver.score.hasBoughtTC = false;
        ScoreSaver.score.totalCoinsEarned = 0;
        ScoreSaver.score.timesJumped = 0;
        ScoreSaver.score.gamesPlayed = 0;
        ScoreSaver.score.lowestRan = 0;
        ScoreSaver.score.hatsOwned = 0;
        ScoreSaver.score.abilitiesOwned = 0;
        PlayerPrefs.SetString("CosEquipped", "-1");
        PlayerPrefs.SetString("Equipped", "-1");
        PlayerPrefs.SetInt("Controls", -1);
        Debug.Log("Player prefs controls =" + PlayerPrefs.GetInt("Controls"));

    ScoreSaver.score.Save();
    }
  
    public void MuteToggle(bool muted)
    {
        if (muted)
        {
            AudioListener.volume = 0;
        }
        else
        {
            AudioListener.volume = 1; 
        }
    }

   

    public void MuteSlider(float vol)
    {
        AudioListener.volume = vol;
        ScoreSaver.score.gameVol = vol;
    }

    public void ButtonPosition(float dist)
    {
        ScoreSaver.score.buttonSpacing = dist; 
        float distanceSpacedJump = (float)(1921 + (400 * dist));
        float distanceSpacedLR = (float)(1000 - (300 * dist));
        movingButton.transform.position = new Vector3(distanceSpacedJump, movingButton.transform.position.y, movingButton.transform.position.z);
        movingButton1.transform.position = new Vector3(distanceSpacedJump, movingButton1.transform.position.y, movingButton1.transform.position.z);


        movingButton2.transform.position = new Vector3(distanceSpacedLR - 400, movingButton2.transform.position.y, movingButton2.transform.position.z);
        movingButton3.transform.position = new Vector3(distanceSpacedLR, movingButton3.transform.position.y, movingButton3.transform.position.z);


    }


    private void PlaySound()
    {
        AudioSource.PlayClipAtPoint(buttonClick, Camera.main.transform.position);

    }

    public void LoadGameControls()
    {
        if (!(ScoreSaver.score.hasSeenControls))
        {
            SceneManager.LoadScene("NewControlsScene");
            ScoreSaver.score.hasSeenControls = true;
        }
        else
        {
            ScoreSaver.score.currentHearts = 3;
            SceneManager.LoadScene("Game");
        }

            
     
    }


    public void LoadStartMenu()
    {
        ScoreSaver.score.Save();
        SceneManager.LoadScene(0);

    }

    public void LoadStore()
    {
        SceneManager.LoadScene("Store");
    }

    public void LoadGame()
    {
        ScoreSaver.score.currentHearts = 3;
        SceneManager.LoadScene("Game");
    }

    public void LoadGameOver()
    {
        SceneManager.LoadScene("Game Over");
    }

    public void QuitGame()
    {
        PlaySound();
        ScoreSaver.score.Save();
        Application.Quit();
    }

    public void LoadCosmetics()
    {

        SceneManager.LoadScene("Cosmetics Store");
    }

    public void UnpauseGame()
    {
        PlaySound();
        PlayerPrefs.SetInt("gamePaused", 0);
        Time.timeScale = 1;
        pauseMenuUI.SetActive(false);
        optionsMenu.SetActive(false);
    }

    public void OpenOptionsMenu()
    {
        PlaySound();
        optionsMenu.SetActive(true);
    }

    public void CloseOptionsMenu()
    {
        PlaySound();
        optionsMenu.SetActive(false);
    }


}
