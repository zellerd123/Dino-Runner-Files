using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinsCount : MonoBehaviour
{
    [SerializeField] static int currentCoins;
    [SerializeField] TextMeshProUGUI ye;
    [SerializeField] AudioClip audioClip;
    

    // Start is called before the first frame update
    void Start()
    {
        GameObject scoreText = GameObject.Find("Coins");
        if (scoreText != null)
        {
            currentCoins = ScoreSaver.score.currentCoinsSaved;
            ye = scoreText.GetComponent<TextMeshProUGUI>();
            ye.text = "Coins: " + ScoreSaver.score.currentCoinsSaved.ToString();
        }
       
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        ScoreSaver.score.currentCoinsSaved++;
        ScoreSaver.score.totalCoinsEarned++;
        ye.text = "Coins: " + ScoreSaver.score.currentCoinsSaved.ToString();
        Debug.Log("Coin Grabbed");
        AudioSource.PlayClipAtPoint(audioClip, Camera.main.transform.position);
        Destroy(gameObject);
    }

    public float GetCurrentCoins()
    {
        return currentCoins; 
    }

    public void DJPurchase()
    {
        ScoreSaver.score.currentCoinsSaved -= 30;
        ye.text = "Coins: " + ScoreSaver.score.currentCoinsSaved.ToString();
    }

    public void CDBPurchase()
    {
        ScoreSaver.score.currentCoinsSaved -= 100;
        ye.text = "Coins: " + ScoreSaver.score.currentCoinsSaved.ToString();
    }

    public void GBPurchase()
    {
        ScoreSaver.score.currentCoinsSaved -= 200;
        ye.text = "Coins: " + ScoreSaver.score.currentCoinsSaved.ToString();
    }

    public void MTPurchase()
    {
        ScoreSaver.score.currentCoinsSaved -= 200;
        ye.text = "Coins: " + ScoreSaver.score.currentCoinsSaved.ToString();
    }

    public void Hat1Purchase()
    {
        ScoreSaver.score.currentCoinsSaved -= 100;
        ye.text = "Coins: " + ScoreSaver.score.currentCoinsSaved.ToString();
    }

    public void Hat2Purchase()
    {
        ScoreSaver.score.currentCoinsSaved -= 300;
        ye.text = "Coins: " + ScoreSaver.score.currentCoinsSaved.ToString();
    }

    public void Hat3Purchase()
    {
        ScoreSaver.score.currentCoinsSaved -= 1000;
        ye.text = "Coins: " + ScoreSaver.score.currentCoinsSaved.ToString();
    }

    public void Hat4Purchase()
    {
        ScoreSaver.score.currentCoinsSaved -= 500;
        ye.text = "Coins: " + ScoreSaver.score.currentCoinsSaved.ToString();
    }

    public void Hat5Purchase()
    {
        ScoreSaver.score.currentCoinsSaved -= 800;
        ye.text = "Coins: " + ScoreSaver.score.currentCoinsSaved.ToString();
    }

    public void Hat6Purchase()
    {
        ScoreSaver.score.currentCoinsSaved -= 3117;
        ye.text = "Coins: " + ScoreSaver.score.currentCoinsSaved.ToString();
    }

    public void TCPurchase()
    {
        ScoreSaver.score.currentCoinsSaved -= 0;
        ye.text = "Coins: " + ScoreSaver.score.currentCoinsSaved.ToString();
    }


}