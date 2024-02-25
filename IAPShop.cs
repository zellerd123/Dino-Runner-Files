using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Purchasing;

public class IAPShop : MonoBehaviour
{
    [SerializeField] CoinsCount coinsCount;
    [SerializeField] CosmeticUILoader cosmeticUI;
    [SerializeField] EquipCosmetic equip;
    [SerializeField] AudioClip click;
    private string burningTC = "com.dougzeller.dinorun.burningteamcaptain";

    public void OnPurchaseComplete(Product product)
    {
        if (product.definition.id == burningTC)
        {

            StartCoroutine(BuyBurningTC());
        }
           
    }
    public IEnumerator BuyBurningTC()
    {
        yield return new WaitForSeconds(.1f);
        ScoreSaver.score.hatsOwned++;
        equip.EquipTC();
        ScoreSaver.score.hasBoughtTC = true;
        cosmeticUI.TCUI();
        coinsCount.TCPurchase();
        AudioSource.PlayClipAtPoint(click, Camera.main.transform.position);
    }

    public void OnPurchaseFailed(Product product, PurchaseFailureReason reason)
    {
        Debug.Log("Purchase of " + product.definition.id + "failed because of " + reason);
    }



}
