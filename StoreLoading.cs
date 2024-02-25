using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreLoading : MonoBehaviour
{
   public bool purchaseUpdate = false;
    // Start is called before the first frame update
    void Start()
    {
  
    }

    // Update is called once per frame

    public void Purchased()
    {
        purchaseUpdate = !purchaseUpdate;
    }

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    public void Purchasedtest()
    {
        if (purchaseUpdate == true)
        {
            print("yo doug");
            Object.Destroy(GameObject.Find("purchase button DJ"));
        } 
    }
}
