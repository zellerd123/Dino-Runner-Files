using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameLoader : MonoBehaviour
{
    [SerializeField] GameObject achievementsTab;
    [SerializeField] GameObject settingsTab;
    [SerializeField] GameObject creditsMenu;
    [SerializeField] Slider slider;
    [SerializeField] AudioClip click;

    private void Start()
    {
        ScoreSaver.score.Load();
        slider.value = ScoreSaver.score.gameVol;
    }

    public void CloseAchievements()
    {
        AudioSource.PlayClipAtPoint(click, Camera.main.transform.position);
        achievementsTab.SetActive(false);
    }

    public void OpenAchievements()
    {
        AudioSource.PlayClipAtPoint(click, Camera.main.transform.position);
        achievementsTab.SetActive(true);
    }

    public void CloseSettings()
    {
        AudioSource.PlayClipAtPoint(click, Camera.main.transform.position);
        settingsTab.SetActive(false);
    }

    public void OpenSettings()
    {
        AudioSource.PlayClipAtPoint(click, Camera.main.transform.position);
        settingsTab.SetActive(true);
    }
    public void OpenCreditsMenu()
    {
        AudioSource.PlayClipAtPoint(click, Camera.main.transform.position);
        creditsMenu.SetActive(true);
    }

    public void CloseCreditsMenu()
    {
        AudioSource.PlayClipAtPoint(click, Camera.main.transform.position);
        creditsMenu.SetActive(false);
    }
}
