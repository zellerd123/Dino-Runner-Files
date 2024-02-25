using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EquipCosmetic : MonoBehaviour
{
    [SerializeField] AudioClip click;
    [SerializeField] GameObject equipHat1;
    [SerializeField] GameObject equipHat2;
    [SerializeField] GameObject equipHat3;
    [SerializeField] GameObject equipHat4;
    [SerializeField] GameObject equipHat5;
    [SerializeField] GameObject equipHat6;
    [SerializeField] GameObject equipTC;

    Color unHighlighted = new Color(195f / 255f, 135f / 255f, 108f / 255f);
    Color highLighted = new Color(126f / 255f, 64f / 255f, 36f / 255f);

    // Start is called before the first frame update
    void Start()
    {
        CurrentEquiped();
    }

    private void CurrentEquiped()
    {
        if (!(PlayerPrefs.HasKey("CosEquipped")))
        {
            return;
        }
        else if ((PlayerPrefs.GetString("CosEquipped") == "0"))
        {
            equipHat1.GetComponent<Image>().color = highLighted;
        }
        else if ((PlayerPrefs.GetString("CosEquipped") == "1"))
        {
           equipHat2.GetComponent<Image>().color = highLighted;
        }
        else if ((PlayerPrefs.GetString("CosEquipped") == "2"))
        {
           equipHat3.GetComponent<Image>().color = highLighted;
        }
        else if ((PlayerPrefs.GetString("CosEquipped") == "3"))
        {
            equipHat4.GetComponent<Image>().color = highLighted;
        }
        else if ((PlayerPrefs.GetString("CosEquipped") == "4"))
        {
            equipHat5.GetComponent<Image>().color = highLighted;
        }
        else if ((PlayerPrefs.GetString("CosEquipped") == "5"))
        {
            equipHat6.GetComponent<Image>().color = highLighted;
        }
        else if ((PlayerPrefs.GetString("CosEquipped") == "6"))
        {
            equipTC.GetComponent<Image>().color = highLighted;
        }
        else
        {
            return;
        }
    }

    public void EquipHat1()
    {


        if (!(PlayerPrefs.GetString("CosEquipped") == "0"))
        {
            AudioSource.PlayClipAtPoint(click, Camera.main.transform.position);
            equipHat1.GetComponent<Image>().color = highLighted;
            PlayerPrefs.SetString("CosEquipped", "0");
            Debug.Log("Says Equipped");
            equipHat5.GetComponent<Image>().color = unHighlighted;
            equipHat3.GetComponent<Image>().color = unHighlighted;
            equipHat4.GetComponent<Image>().color = unHighlighted;
            equipHat2.GetComponent<Image>().color = unHighlighted;
            equipHat6.GetComponent<Image>().color = unHighlighted;
            equipTC.GetComponent<Image>().color = unHighlighted;

        }
        else
        {
            AudioSource.PlayClipAtPoint(click, Camera.main.transform.position);
            equipHat1.GetComponent<Image>().color = unHighlighted;
            PlayerPrefs.SetString("CosEquipped", "-1");
            Debug.Log("Says not Equipped");
        }

    }

    public void EquipHat2()
    {


        if (!(PlayerPrefs.GetString("CosEquipped") == "1"))
        {
            AudioSource.PlayClipAtPoint(click, Camera.main.transform.position);
            equipHat2.GetComponent<Image>().color = highLighted;
            PlayerPrefs.SetString("CosEquipped", "1");
            Debug.Log("Says Equipped");
            equipHat5.GetComponent<Image>().color = unHighlighted;
            equipHat3.GetComponent<Image>().color = unHighlighted;
            equipHat4.GetComponent<Image>().color = unHighlighted;
            equipHat6.GetComponent<Image>().color = unHighlighted;
            equipHat1.GetComponent<Image>().color = unHighlighted;
            equipTC.GetComponent<Image>().color = unHighlighted;

        }
        else
        {
            AudioSource.PlayClipAtPoint(click, Camera.main.transform.position);
            equipHat2.GetComponent<Image>().color = unHighlighted;
            PlayerPrefs.SetString("CosEquipped", "-1");
            Debug.Log("Says not Equipped");
        }

    }

    public void EquipHat3()
    {


        if (!(PlayerPrefs.GetString("CosEquipped") == "2"))
        {
            AudioSource.PlayClipAtPoint(click, Camera.main.transform.position);
            equipHat3.GetComponent<Image>().color = highLighted;
            PlayerPrefs.SetString("CosEquipped", "2");
            Debug.Log("Says Equipped");
            equipHat5.GetComponent<Image>().color = unHighlighted;
            equipHat6.GetComponent<Image>().color = unHighlighted;
            equipHat4.GetComponent<Image>().color = unHighlighted;
            equipHat2.GetComponent<Image>().color = unHighlighted;
            equipHat1.GetComponent<Image>().color = unHighlighted;
            equipTC.GetComponent<Image>().color = unHighlighted;

        }
        else
        {
            AudioSource.PlayClipAtPoint(click, Camera.main.transform.position);
            equipHat3.GetComponent<Image>().color = unHighlighted;
            PlayerPrefs.SetString("CosEquipped", "-1");
            Debug.Log("Says not Equipped");
        }

    }
    public void EquipHat4()
    {


        if (!(PlayerPrefs.GetString("CosEquipped") == "3"))
        {
            AudioSource.PlayClipAtPoint(click, Camera.main.transform.position);
            equipHat4.GetComponent<Image>().color = highLighted;
            PlayerPrefs.SetString("CosEquipped", "3");
            Debug.Log("Says Equipped");
            equipHat5.GetComponent<Image>().color = unHighlighted;
            equipHat3.GetComponent<Image>().color = unHighlighted;
            equipHat6.GetComponent<Image>().color = unHighlighted;
            equipHat2.GetComponent<Image>().color = unHighlighted;
            equipHat1.GetComponent<Image>().color = unHighlighted;
            equipTC.GetComponent<Image>().color = unHighlighted;

        }
        else
        {
            AudioSource.PlayClipAtPoint(click, Camera.main.transform.position);
            equipHat4.GetComponent<Image>().color = unHighlighted;
            PlayerPrefs.SetString("CosEquipped", "-1");
            Debug.Log("Says not Equipped");
        }

    }
    public void EquipHat5()
    {


        if (!(PlayerPrefs.GetString("CosEquipped") == "4"))
        {
            AudioSource.PlayClipAtPoint(click, Camera.main.transform.position);
            equipHat5.GetComponent<Image>().color = highLighted;
            PlayerPrefs.SetString("CosEquipped", "4");
            Debug.Log("Says Equipped");
            equipHat6.GetComponent<Image>().color = unHighlighted;
            equipHat3.GetComponent<Image>().color = unHighlighted;
            equipHat4.GetComponent<Image>().color = unHighlighted;
            equipHat2.GetComponent<Image>().color = unHighlighted;
            equipHat1.GetComponent<Image>().color = unHighlighted;
            equipTC.GetComponent<Image>().color = unHighlighted;

        }
        else
        {
            AudioSource.PlayClipAtPoint(click, Camera.main.transform.position);
            equipHat5.GetComponent<Image>().color = unHighlighted;
            PlayerPrefs.SetString("CosEquipped", "-1");
            Debug.Log("Says not Equipped");
        }

    }
    public void EquipHat6()
    {


        if (!(PlayerPrefs.GetString("CosEquipped") == "5"))
        {
            AudioSource.PlayClipAtPoint(click, Camera.main.transform.position);
            equipHat6.GetComponent<Image>().color = highLighted;
            PlayerPrefs.SetString("CosEquipped", "5");
            Debug.Log("Says Equipped");
            equipHat5.GetComponent<Image>().color = unHighlighted;
            equipHat3.GetComponent<Image>().color = unHighlighted;
            equipHat4.GetComponent<Image>().color = unHighlighted;
            equipHat2.GetComponent<Image>().color = unHighlighted;
            equipHat1.GetComponent<Image>().color = unHighlighted;
            equipTC.GetComponent<Image>().color = unHighlighted;

        }
        else
        {
            AudioSource.PlayClipAtPoint(click, Camera.main.transform.position);
            equipHat6.GetComponent<Image>().color = unHighlighted;
            PlayerPrefs.SetString("CosEquipped", "-1");
            Debug.Log("Says not Equipped");
        }

    }

    public void EquipTC()
    {


        if (!(PlayerPrefs.GetString("CosEquipped") == "6"))
        {
            AudioSource.PlayClipAtPoint(click, Camera.main.transform.position);
            equipTC.GetComponent<Image>().color = highLighted;
            PlayerPrefs.SetString("CosEquipped", "6");
            Debug.Log("Says Equipped");
            equipHat5.GetComponent<Image>().color = unHighlighted;
            equipHat3.GetComponent<Image>().color = unHighlighted;
            equipHat4.GetComponent<Image>().color = unHighlighted;
            equipHat2.GetComponent<Image>().color = unHighlighted;
            equipHat1.GetComponent<Image>().color = unHighlighted;
            equipHat6.GetComponent<Image>().color = unHighlighted;

        }
        else
        {
            AudioSource.PlayClipAtPoint(click, Camera.main.transform.position);
            equipTC.GetComponent<Image>().color = unHighlighted;
            PlayerPrefs.SetString("CosEquipped", "-1");
            Debug.Log("Says not Equipped");
        }

    }

}
