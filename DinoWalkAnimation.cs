using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinoWalkAnimation : MonoBehaviour
{
    [SerializeField] SpriteRenderer spriteRenderer;
    [SerializeField] Sprite[] nextSprites;
    [SerializeField] Sprite[] nextSpritesDamage;
    [SerializeField] int timeBetweenSteps = 3;
    [SerializeField] int amountOfFrames = 6;
    [SerializeField] Player player;
    [SerializeField] GameObject hat;
    float gameTimeBetweenSteps;
    int i = 0;
    int t = 0;
    int frames = 0;
    private int realAmount = 6;
    private bool pause = false;
    private bool pause2 = false;
    private bool bounce = false;
    // Start is called before the first frame update
    void Start()
    {
        GameObject duck = GameObject.Find("Dino MC");
        player = duck.GetComponent<Player>();
        if (tag == "MC")
        {
            StartCoroutine(WaitForTag());
        }
        
        if (tag == "Red Dino")
        {
            transform.Rotate(Vector3.up * 180);
        }
    }

    // Update is called once per frame
    void Update()
    {
        frames++;
        if (!player.IsGrounded() && tag == "MC") { pause = true; }
        else { pause = false; }
        if (frames > timeBetweenSteps && !pause && !pause2 && (PlayerPrefs.GetInt("gamePaused") == 0))
        {
            SpriteAdder();
            frames = 0;
        }

    }

    IEnumerator WaitForTag()
    {
        yield return new WaitForEndOfFrame();
        hat = GameObject.FindGameObjectWithTag("hat");
    }

    private void SpriteAdder()
    {


        spriteRenderer.sprite = nextSprites[i];
        i++;
        Debug.Log("is it running this while frozen?");
        if (i > amountOfFrames)
        {
           
            if (tag == "MC")
            {
                i = 1;
            }
            else
            {
                i = 0;
            }
        }
        if (tag == "MC" && hat != null)
        {
            
            Debug.Log("(I is) Amount of frames is: " + amountOfFrames);
            Debug.Log("I is: " + i + ", T is: " + t);
            if (t == 2)
                {
                    hat.transform.position = new Vector3(hat.transform.position.x, hat.transform.position.y - .075f, hat.transform.position.z);
                }
            else if (t == 3)
                {
                    hat.transform.position = new Vector3(hat.transform.position.x, hat.transform.position.y + .075f, hat.transform.position.z);
                    t = 0;
                }
            t++;

        }
        
        
    }

    public void DamageInitializer()
    {
      pause2 = true;
       
        

        StartCoroutine(DamageAni());

    }



    IEnumerator DamageAni()
    {
        for (int k = 0; k < 3; k++)
        {
            spriteRenderer.sprite = nextSpritesDamage[k];
            yield return new WaitForSeconds(.1f);
        }
        Debug.Log("hi");
        pause2 = false;
    }

 
}