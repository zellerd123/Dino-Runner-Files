using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CosmeticPurchaseSystem : MonoBehaviour
{
    [SerializeField] CoinsCount coinsCount;
    [SerializeField] CosmeticUILoader cosmeticUI;
    [SerializeField] EquipCosmetic equip;
    [SerializeField] AudioClip click;
    // Start is called before the first frame update

    private void Start()
    {
        Time.timeScale = 1; 
    }

    public void PurchaseHat1()
    {
        if (ScoreSaver.score.currentCoinsSaved >= 100)
        {
            ScoreSaver.score.hatsOwned++;
            equip.EquipHat1();
            ScoreSaver.score.hasBoughtHat1 = true;
            cosmeticUI.Hat1UI();
            coinsCount.Hat1Purchase();
            AudioSource.PlayClipAtPoint(click, Camera.main.transform.position);
        }
    }

    public void PurchaseHat2()
    {
        if (ScoreSaver.score.currentCoinsSaved >= 300)
        {
            ScoreSaver.score.hatsOwned++;
            equip.EquipHat2();
            ScoreSaver.score.hasBoughtHat2 = true;
            cosmeticUI.Hat2UI();
            coinsCount.Hat2Purchase();
            AudioSource.PlayClipAtPoint(click, Camera.main.transform.position);
        }
    }

    public void PurchaseHat3()
    {
        if (ScoreSaver.score.currentCoinsSaved >= 1000)
        {
            ScoreSaver.score.hatsOwned++;
            equip.EquipHat3();
            ScoreSaver.score.hasBoughtHat3 = true;
            cosmeticUI.Hat3UI();
            coinsCount.Hat3Purchase();
            AudioSource.PlayClipAtPoint(click, Camera.main.transform.position);
        }
    }

    public void PurchaseHat4()
    {
        if (ScoreSaver.score.currentCoinsSaved >= 500)
        {
            ScoreSaver.score.hatsOwned++;
            equip.EquipHat4();
            ScoreSaver.score.hasBoughtHat4 = true;
            cosmeticUI.Hat4UI();
            coinsCount.Hat4Purchase();
            AudioSource.PlayClipAtPoint(click, Camera.main.transform.position);
        }
    }

    public void PurchaseHat5()
    {
        if (ScoreSaver.score.currentCoinsSaved >= 800)
        {
            ScoreSaver.score.hatsOwned++;
            equip.EquipHat5();
            ScoreSaver.score.hasBoughtHat5 = true;
            cosmeticUI.Hat5UI();
            coinsCount.Hat5Purchase();
            AudioSource.PlayClipAtPoint(click, Camera.main.transform.position);
        }
    }

    public void PurchaseHat6()
    {
        if (ScoreSaver.score.currentCoinsSaved >= 3117)
        {
            ScoreSaver.score.hatsOwned++;
            equip.EquipHat6();
            ScoreSaver.score.hasBoughtHat6 = true;
            cosmeticUI.Hat6UI();
            coinsCount.Hat6Purchase();
            AudioSource.PlayClipAtPoint(click, Camera.main.transform.position);
        }
    }

    public void PurchaseTC()
    {
        if (ScoreSaver.score.currentCoinsSaved >= 10000)
        {
            ScoreSaver.score.hatsOwned++;
            equip.EquipTC();
            ScoreSaver.score.hasBoughtTC = true;
            cosmeticUI.TCUI();
            coinsCount.TCPurchase();
            AudioSource.PlayClipAtPoint(click, Camera.main.transform.position);
        }
    }




}
