using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Equiped : MonoBehaviour
{
    [SerializeField] GameObject EquipUIDJ;
    [SerializeField] GameObject EquipUICDB;
    [SerializeField] GameObject EquipUIGB;
    [SerializeField] GameObject EquipUIMT;
    [SerializeField] AudioClip click;
    Color unHighlighted = new Color(195f / 255f, 135f / 255f, 108f / 255f);
    Color highLighted = new Color(126f / 255f, 64f / 255f, 36f / 255f);
    private void Start()
    {
        Debug.Log("player prefs is " + PlayerPrefs.GetString("Equipped"));
        CurrentEquiped();
    }

    private void CurrentEquiped()
    {
        if (!(PlayerPrefs.HasKey("Equipped")))
        {
            return;
        }
        else if ((PlayerPrefs.GetString("Equipped") == "0"))
        {  
            EquipUIDJ.GetComponent<Image>().color = highLighted;
        }
        else if ((PlayerPrefs.GetString("Equipped") == "1"))
        {
            EquipUICDB.GetComponent<Image>().color = highLighted;
        }
        else if ((PlayerPrefs.GetString("Equipped") == "2"))
        {
            EquipUIGB.GetComponent<Image>().color = highLighted;
        }
        else if ((PlayerPrefs.GetString("Equipped") == "3"))
        {
            EquipUIMT.GetComponent<Image>().color = highLighted;
        }
        else
        {
            return;
        }
    }


    public void EquipDubJump()
    {

       
        if (!(PlayerPrefs.GetString("Equipped") == "0"))
        {
            EquipUIDJ.GetComponent<Image>().color = highLighted;
            PlayerPrefs.SetString("Equipped", "0");
            Debug.Log("Says Equipped");
            EquipUICDB.GetComponent<Image>().color = unHighlighted;
            EquipUIGB.GetComponent<Image>().color = unHighlighted;
            EquipUIMT.GetComponent<Image>().color = unHighlighted;
        }
        else
        {
            EquipUIDJ.GetComponent<Image>().color = unHighlighted;
            PlayerPrefs.SetString("Equipped", "-1");
            Debug.Log("Says not Equipped");
        }
        AudioSource.PlayClipAtPoint(click, Camera.main.transform.position);

    }

    public void EquipBurst()
    {


        if (!(PlayerPrefs.GetString("Equipped") == "1"))
        {
            EquipUICDB.GetComponent<Image>().color = highLighted;
            PlayerPrefs.SetString("Equipped", "1");
            Debug.Log("Says Equipped Burst");
            EquipUIDJ.GetComponent<Image>().color = unHighlighted;
            EquipUIGB.GetComponent<Image>().color = unHighlighted;
            EquipUIMT.GetComponent<Image>().color = unHighlighted;

        }
        else
        {
            EquipUICDB.GetComponent<Image>().color = unHighlighted;
            PlayerPrefs.SetString("Equipped", "-1");
            Debug.Log("Says not Equipped Burst");
        }
        AudioSource.PlayClipAtPoint(click, Camera.main.transform.position);

    }

    public void EquipGoomba()
    {


        if (!(PlayerPrefs.GetString("Equipped") == "2"))
        {
            EquipUIGB.GetComponent<Image>().color = highLighted;
            PlayerPrefs.SetString("Equipped", "2");
            Debug.Log("Says Equipped Goomba");
            EquipUIDJ.GetComponent<Image>().color = unHighlighted;
            EquipUICDB.GetComponent<Image>().color = unHighlighted;
            EquipUIMT.GetComponent<Image>().color = unHighlighted;


        }
        else
        {
            EquipUIGB.GetComponent<Image>().color = unHighlighted;
            PlayerPrefs.SetString("Equipped", "-1");
            Debug.Log("Says not Equipped Goomba");
        }
        AudioSource.PlayClipAtPoint(click, Camera.main.transform.position);

    }

    public void EquipTreads()
    {


        if (!(PlayerPrefs.GetString("Equipped") == "3"))
        {
            EquipUIMT.GetComponent<Image>().color = highLighted;
            PlayerPrefs.SetString("Equipped", "3");
            Debug.Log("Says Equipped Treads");
            EquipUIDJ.GetComponent<Image>().color = unHighlighted;
            EquipUIGB.GetComponent<Image>().color = unHighlighted;
            EquipUICDB.GetComponent<Image>().color = unHighlighted;

        }
        else
        {
            EquipUIMT.GetComponent<Image>().color = unHighlighted;
            PlayerPrefs.SetString("Equipped", "-1");
            Debug.Log("Says not Equipped Treads");
        }
        AudioSource.PlayClipAtPoint(click, Camera.main.transform.position);

    }

    //new Color( 17,104, 65)


}
