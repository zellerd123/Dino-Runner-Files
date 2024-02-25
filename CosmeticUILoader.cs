using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CosmeticUILoader : MonoBehaviour
{
    [SerializeField] Sprite clickedLeft;
    [SerializeField] Sprite unclickedLeft;
    [SerializeField] Sprite clickedRight;
    [SerializeField] Sprite unclickedRight;
    [SerializeField] Sprite clickedGrail;
    [SerializeField] Sprite unclickedGrail;
    [SerializeField] Button leftButton;
    [SerializeField] Button rightButton;
    [SerializeField] Button centerButton;
    [SerializeField] GameObject tab1;
    [SerializeField] GameObject tab2;
    [SerializeField] GameObject tab3;



    [SerializeField] GameObject purchaseHat1;
    [SerializeField] GameObject EquipHat1;
    [SerializeField] GameObject purchaseHat2;
    [SerializeField] GameObject EquipHat2;
    [SerializeField] GameObject purchaseHat3;
    [SerializeField] GameObject EquipHat3;
    [SerializeField] AudioClip click;
    [SerializeField] GameObject purchaseHat4;
    [SerializeField] GameObject EquipHat4;
    [SerializeField] GameObject purchaseHat5;
    [SerializeField] GameObject EquipHat5;
    [SerializeField] GameObject purchaseHat6;
    [SerializeField] GameObject EquipHat6;
    [SerializeField] GameObject purchaseTC;
    [SerializeField] GameObject EquipTC;

    private int clicked = -1;

    // Start is called before the first frame update
    void Start()
    {
        clicked = 0;
        leftButton.image.sprite = unclickedLeft;
        rightButton.image.sprite = clickedRight;
        centerButton.image.sprite = clickedGrail;
        tab1.SetActive(true);
        tab2.SetActive(false);
        tab3.SetActive(false);
        Hat1UI();
        Hat2UI();
        Hat3UI();
        Hat4UI();
        Hat5UI();
        Hat6UI();
        TCUI();

    }

    // Update is called once per frame
    public void OnLeftClick()
    {
        if (clicked != 0)
        {
            clicked = 0;
            leftButton.image.sprite = unclickedLeft;
            rightButton.image.sprite = clickedRight;
            centerButton.image.sprite = clickedGrail;
            tab1.SetActive(true);
            tab2.SetActive(false);
            tab3.SetActive(false);
            AudioSource.PlayClipAtPoint(click, Camera.main.transform.position); 

        }
        else
        {
            return;
        }
    }

    public void OnRightClick()
    {
        if (clicked != 1)
        {
            clicked = 1;
            rightButton.image.sprite = unclickedRight;
            leftButton.image.sprite = clickedLeft;
            centerButton.image.sprite = clickedGrail;
            tab3.SetActive(true);
            tab2.SetActive(false);
            tab1.SetActive(false);
            AudioSource.PlayClipAtPoint(click, Camera.main.transform.position);

        }
        else
        {
            return;
        }
    }

    public void OnCenterClick()
    {
        if (clicked != 2)
        {
            clicked = 2;
            centerButton.image.sprite = unclickedGrail;
            rightButton.image.sprite = clickedRight;
            leftButton.image.sprite = clickedLeft;
            tab2.SetActive(true);
            tab1.SetActive(false);
            tab3.SetActive(false);
            AudioSource.PlayClipAtPoint(click, Camera.main.transform.position);

        }
        else
        {
            return;
        }
    }

    public void Hat1UI()
    {
        if (ScoreSaver.score.hasBoughtHat1)
        {
            purchaseHat1.SetActive(false);
            EquipHat1.SetActive(true);
            Debug.Log("Hat1UI function success");
        }
        else
        {
            purchaseHat1.SetActive(true);
            EquipHat1.SetActive(false);
        }
    }

    public void Hat2UI()
    {
        if (ScoreSaver.score.hasBoughtHat2)
        {
            purchaseHat2.SetActive(false);
            EquipHat2.SetActive(true);
            Debug.Log("Hat2UI function success");
        }
        else
        {
            purchaseHat2.SetActive(true);
            EquipHat2.SetActive(false);
        }
    }

    public void Hat3UI()
    {
        if (ScoreSaver.score.hasBoughtHat3)
        {
            purchaseHat3.SetActive(false);
            EquipHat3.SetActive(true);
            Debug.Log("Hat3UI function success");
        }
        else
        {
            purchaseHat3.SetActive(true);
            EquipHat3.SetActive(false);
        }
    }

    public void Hat4UI()
    {
        if (ScoreSaver.score.hasBoughtHat4)
        {
            purchaseHat4.SetActive(false);
            EquipHat4.SetActive(true);
            Debug.Log("Hat4UI function success");
        }
        else
        {
            purchaseHat4.SetActive(true);
            EquipHat4.SetActive(false);
        }
    }

    public void Hat5UI()
    {
        if (ScoreSaver.score.hasBoughtHat5)
        {
            purchaseHat5.SetActive(false);
            EquipHat5.SetActive(true);
            Debug.Log("Hat5UI function success");
        }
        else
        {
            purchaseHat5.SetActive(true);
            EquipHat5.SetActive(false);
        }
    }

    public void Hat6UI()
    {
        if (ScoreSaver.score.hasBoughtHat6)
        {
            purchaseHat6.SetActive(false);
            EquipHat6.SetActive(true);
            Debug.Log("Hat6UI function success");
        }
        else
        {
            purchaseHat6.SetActive(true);
            EquipHat6.SetActive(false);
        }
    }

    public void TCUI()
    {
        if (ScoreSaver.score.hasBoughtTC)
        {
            purchaseTC.SetActive(false);
            EquipTC.SetActive(true);
            Debug.Log("TC function success");
        }
        else
        {
            purchaseTC.SetActive(true);
            EquipTC.SetActive(false);
        }
    }




}
