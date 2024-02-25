using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PurchaseSystem : MonoBehaviour
{
    [SerializeField] CoinsCount coinsCount;
    [SerializeField] StoreUILoader storeUI;
    [SerializeField] Equiped equiped;
    [SerializeField] AudioClip click;
    
    public static bool doubleJump = false;
    // Start is called before the first frame update
    void Start()
    {
        
        GameObject coin = GameObject.Find("Coin");
        coinsCount = coin.GetComponent<CoinsCount>();
    }


    public void PurchaseDoubleJump()
    {
        if (coinsCount.GetCurrentCoins() >= 30)
        {
            ScoreSaver.score.abilitiesOwned++;
            AudioSource.PlayClipAtPoint(click, Camera.main.transform.position);
            equiped.EquipDubJump();
            ScoreSaver.score.hasBoughtDJ = true; 
            doubleJump = true;
            storeUI.DJUI();
            coinsCount.DJPurchase();
        }
    }

    public void PurchaseCDB()
    {
        if (coinsCount.GetCurrentCoins() >= 100)
        {
            ScoreSaver.score.abilitiesOwned++;
            AudioSource.PlayClipAtPoint(click, Camera.main.transform.position);
            equiped.EquipBurst();
            ScoreSaver.score.hasBoughtCDB = true;
            storeUI.CDBUI();
            coinsCount.CDBPurchase();
        }
    }

    public void PurchaseGB()
    {
        if (coinsCount.GetCurrentCoins() >= 200)
        {
            ScoreSaver.score.abilitiesOwned++;
            AudioSource.PlayClipAtPoint(click, Camera.main.transform.position);
            equiped.EquipGoomba();
            ScoreSaver.score.hasBoughtGB = true;
            storeUI.GBUI();
            coinsCount.GBPurchase();
        }
    }

    public void PurchaseMT()
    {
        if (coinsCount.GetCurrentCoins() >= 200)
        {
            ScoreSaver.score.abilitiesOwned++;
            AudioSource.PlayClipAtPoint(click, Camera.main.transform.position);
            equiped.EquipTreads();
            ScoreSaver.score.hasBoughtMT = true;
            storeUI.MTUI();
            coinsCount.MTPurchase();
        }
    }

    public bool getDoubleJump()
    {
        return doubleJump;
    }
}
