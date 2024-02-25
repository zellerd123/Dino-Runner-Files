using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreUILoader : MonoBehaviour
{
    [SerializeField] GameObject purchaseUIDJ;
    [SerializeField] GameObject EquipUIDJ;
    [SerializeField] GameObject purchaseUICDB;
    [SerializeField] GameObject EquipUICDB;
    [SerializeField] GameObject purchaseUIGB;
    [SerializeField] GameObject EquipUIGB;
    [SerializeField] GameObject purchaseUIMT;
    [SerializeField] GameObject EquipUIMT;
    // Start is called before the first frame update
    void Start()
    {
        DJUI();
        CDBUI();
        GBUI();
        MTUI();
    }

    public void DJUI()
    {
        if (ScoreSaver.score.hasBoughtDJ)
        {
            purchaseUIDJ.SetActive(false);
            EquipUIDJ.SetActive(true);
            Debug.Log("DJUI function success");
        }
        else
        {
            purchaseUIDJ.SetActive(true);
            EquipUIDJ.SetActive(false);
        }
    }

    public void CDBUI()
    {
        if (ScoreSaver.score.hasBoughtCDB)
        {
            purchaseUICDB.SetActive(false);
            EquipUICDB.SetActive(true);
            Debug.Log("CDBUI function success");
        }
        else
        {
            purchaseUICDB.SetActive(true);
            EquipUICDB.SetActive(false);
        }
    }

    public void GBUI()
    {
        if (ScoreSaver.score.hasBoughtGB)
        {
            purchaseUIGB.SetActive(false);
            EquipUIGB.SetActive(true);
            Debug.Log("GBUI function success");
        }
        else
        {
            purchaseUIGB.SetActive(true);
            EquipUIGB.SetActive(false);
        }
    }

    public void MTUI()
    {
        if (ScoreSaver.score.hasBoughtMT)
        {
            purchaseUIMT.SetActive(false);
            EquipUIMT.SetActive(true);
            Debug.Log("MTUI function success");
        }
        else
        {
            purchaseUIMT.SetActive(true);
            EquipUIMT.SetActive(false);
        }
    }



}
