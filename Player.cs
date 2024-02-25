using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.CrossPlatformInput;


public class Player : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;
    [SerializeField] float jumpingMoveSpeed = 3f;
    [SerializeField] private LayerMask platformLayerMask;
    public Rigidbody2D rb;
    public float jumpAmount = 10;
    public BoxCollider2D polygonCollider2D;
    [SerializeField] bool canDoubleJump;
    [SerializeField] PurchaseSystem purchaseSystem;
    [SerializeField] AudioClip jumpSound;
    [SerializeField] AudioClip dJumpSound;
    [SerializeField] AudioClip burstSound;
    [SerializeField] AudioClip stompSound;
    [SerializeField] AudioClip deathSound;
    [SerializeField] AudioClip clickSound;
    public ParticleSystem dust;
    public ParticleSystem dust2;
    public ParticleSystem CDBdust;
    public ParticleSystem GBDust;
    public SpriteRenderer sprite;
    private bool damageTaken = false;
    float deltaX;
    bool burst = false;
    bool stomp = false; 
    [SerializeField] GameObject pauseMenuUI;
    [SerializeField] GameObject optionsMenu;
    [SerializeField] GameObject bubble;
    [SerializeField] GameObject hat1;
    [SerializeField] GameObject hat2;
    [SerializeField] GameObject hat3;
    [SerializeField] GameObject hat4;
    [SerializeField] GameObject hat5;
    [SerializeField] GameObject hat6;
    [SerializeField] GameObject burningTC;
    private float gameTime = 1f;
    private GameObject invincBubble;
    private GameObject loadedHat;
    private SpriteRenderer hatSprite;
    private bool hatFlip = false;
    private bool flipping = false;
    public bool canMove = true;

    // Start is called before the first frame update
    void Start()
    {
        polygonCollider2D = transform.GetComponent<BoxCollider2D>();
        pauseMenuUI.SetActive(false);
        optionsMenu.SetActive(false);
        Time.timeScale = 1f;
        PlayerPrefs.SetInt("gamePaused", 0);
        CosmeticApplier();
        canMove = true;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Damage shown constant log " + damageTaken);
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            
            if (PlayerPrefs.GetInt("gamePaused") == 1)
            {
                PlayerPrefs.SetInt("gamePaused", 0);
                ResumeGame();
            }
            else
            {
                
                PauseGame();

            }
            AudioSource.PlayClipAtPoint(clickSound, Camera.main.transform.position);
        }
        if (canMove)
        {
            JumpSpeed();
            LandedReactivator();
            Move();
            Jump();
            Burst();
            Goomba();
        }
        


    }

    private void CosmeticApplier()
    {
        Debug.Log("this is player prefs:" + PlayerPrefs.GetString("CosEquipped"));
        if (ScoreSaver.score.hasBoughtHat1 && PlayerPrefs.GetString("CosEquipped") == "0")
        {
            Debug.Log("Hat is said to have spawned");
            loadedHat = Instantiate(hat1, new Vector3(transform.position.x -.2f, transform.position.y + .9f, transform.position.z - 2), Quaternion.identity);
            loadedHat.transform.parent = gameObject.transform;
        }
        else if (ScoreSaver.score.hasBoughtHat2 && PlayerPrefs.GetString("CosEquipped") == "1")
        {
            loadedHat = Instantiate(hat2, new Vector3(transform.position.x - .2f, transform.position.y + .9f, transform.position.z - 2), Quaternion.identity);
            loadedHat.transform.parent = gameObject.transform;
        }

        else if (ScoreSaver.score.hasBoughtHat3 && PlayerPrefs.GetString("CosEquipped") == "2")
        {
            loadedHat = Instantiate(hat3, new Vector3(transform.position.x - .2f, transform.position.y + 1.1f, transform.position.z - 2), Quaternion.identity);
            loadedHat.transform.parent = gameObject.transform;
        }
        else if (ScoreSaver.score.hasBoughtHat4 && PlayerPrefs.GetString("CosEquipped") == "3")
        {
            loadedHat = Instantiate(hat4, new Vector3(transform.position.x - .2f, transform.position.y + 1.25f, transform.position.z - 2), Quaternion.identity);
            loadedHat.transform.parent = gameObject.transform;
        }
        else if (ScoreSaver.score.hasBoughtHat5 && PlayerPrefs.GetString("CosEquipped") == "4")
        {
            loadedHat = Instantiate(hat5, new Vector3(transform.position.x - .2f, transform.position.y + .9f, transform.position.z - 2), Quaternion.identity);
            loadedHat.transform.parent = gameObject.transform;
        }
        else if (ScoreSaver.score.hasBoughtHat6 && PlayerPrefs.GetString("CosEquipped") == "5")
        {
            loadedHat = Instantiate(hat6, new Vector3(transform.position.x - .2f, transform.position.y + 1.35f, transform.position.z - 2), Quaternion.identity);
            loadedHat.transform.parent = gameObject.transform;
        }
        else if (ScoreSaver.score.hasBoughtTC && PlayerPrefs.GetString("CosEquipped") == "6")
        {
            loadedHat = Instantiate(burningTC, new Vector3(transform.position.x - .2f, transform.position.y + .9f, transform.position.z - 2), Quaternion.identity);
            loadedHat.transform.parent = gameObject.transform;
        }
    
        else 
        {
            
        }
    
        if (loadedHat != null)
        {
            hatSprite = loadedHat.GetComponent<SpriteRenderer>();
        }
        

    }

    private void JumpSpeed()
    {
        if (ScoreSaver.score.hasBoughtMT && (PlayerPrefs.GetString("Equipped") == "3"))
        {
            jumpingMoveSpeed = 7f;
        }
        else
        {
            jumpingMoveSpeed = 3f;
        }
    }

    private void LandedReactivator()
    {
        if (IsGrounded() && ScoreSaver.score.hasBoughtDJ && (PlayerPrefs.GetString("Equipped") == "0"))
        {
            canDoubleJump = true;
        }
        if (IsGrounded() && ScoreSaver.score.hasBoughtCDB && (PlayerPrefs.GetString("Equipped") == "1"))
        {
            burst = true;
        }
        if (IsGrounded() && ScoreSaver.score.hasBoughtGB && (PlayerPrefs.GetString("Equipped") == "2"))
        {
            stomp = true; 
        }
    }

    private void Goomba()
    {
        if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (!IsGrounded() && stomp)
            {
                float stompVel = 15f;
                rb.velocity = (Vector2.down * stompVel);
                stomp = false;
                StartCoroutine(WaitGrounded());
            }
            
            
        }
    }

    IEnumerator WaitGrounded()
    {
        while (!IsGrounded())
        {
            yield return new WaitForSeconds(.01f);
        }

        CreateGBDust();
        AudioSource.PlayClipAtPoint(stompSound, Camera.main.transform.position);
    }

    private void Burst()
    {
        if (Input.GetKeyDown(KeyCode.R) || Input.GetKeyDown(KeyCode.F))
        {
            if (!IsGrounded() && burst)
            {
                Debug.Log("Burst function called");
                CreateCDBDust();
                AudioSource.PlayClipAtPoint(burstSound, Camera.main.transform.position);
                float burstVel = 7f;
                float upVel = 3;
                rb.velocity = (Vector2.right * burstVel) + (Vector2.up * upVel);
                burst = false;

            }
        }
    }

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (IsGrounded())
            {
                AudioSource.PlayClipAtPoint(jumpSound, Camera.main.transform.position);
                float jumpVel = 9f;
                rb.velocity = (Vector2.up * jumpVel);
                CreateDust();
                ScoreSaver.score.timesJumped++;
            }
            else
            {
                if (canDoubleJump)
                {
                    AudioSource.PlayClipAtPoint(dJumpSound, Camera.main.transform.position);
                    float jumpVel = 7f;
                    rb.velocity = (Vector2.up * jumpVel);
                    canDoubleJump = false;
                    CreateDust2();
                    ScoreSaver.score.timesJumped++;

                    StartCoroutine(Flip(40));

                }
            }
        }
    }

    IEnumerator Flip(int i)
    {
        flipping = true;
           for( int k = i; i > 0; i--)
        {
            transform.Rotate((Vector3.forward * -9));
            yield return new WaitForSeconds(.015f);
            k--;
        }
        flipping = false;
        

    }

    public void Damage()
    {
       
        
            Debug.Log("Damage shown function activated");
            damageTaken = true;
            if (ScoreSaver.score.currentHearts > 0)
            {
                invincBubble = Instantiate(bubble, new Vector3(transform.position.x, transform.position.y, transform.position.z - 4), Quaternion.identity);
                invincBubble.transform.parent = gameObject.transform;
            }
            StartCoroutine(DamageReset());

        

    }

    public IEnumerator DamageReset()
    {
        yield return new WaitForSeconds(1f);
        Debug.Log("Damage shown CoRoutine Works");
        damageTaken = false;
        if (ScoreSaver.score.currentHearts > 0)
        {
            Destroy(invincBubble);
        }
        Debug.Log("Damage shown modifier Works if :" + damageTaken);
    }


    public bool GetDamage()
    {
        return damageTaken; 
    }

    public IEnumerator DeathAnimation(int i)
    {
        AudioSource.PlayClipAtPoint(deathSound, Camera.main.transform.position);
        canMove = false;
        Debug.Log("is it running this start of death?");
        BoxCollider2D dinohit = GetComponent<BoxCollider2D>();
        dinohit.isTrigger = true;
        for (; i > 0; i--)
        {
            transform.Rotate(Vector3.forward * -9);
            yield return new WaitForSeconds(.08f);
            Debug.Log(i);
        }
        ScoreSaver.score.gamesPlayed++;
        ScoreSaver.score.Save();
        SceneManager.LoadScene("Game Over");
    }

    public bool IsGrounded()
    {
        if (ScoreSaver.score.currentHearts > 0)
        {
            float extraHeightTest = .5f;
            RaycastHit2D raycastHit = Physics2D.Raycast(polygonCollider2D.bounds.center,
                Vector2.down, polygonCollider2D.bounds.extents.y + extraHeightTest, platformLayerMask);
            Color rayColor;
            if (raycastHit.collider != null)
            {
                rayColor = Color.green;
            }
            else
            {
                rayColor = Color.red;
            }
            Debug.DrawRay(polygonCollider2D.bounds.center, Vector2.down * (polygonCollider2D.bounds.extents.y + extraHeightTest), rayColor);
            Debug.Log(raycastHit.collider);
            return raycastHit.collider != null;
        }
        else
        {
            return false;
        }
        
    }

    private void Move()
    {
        
        if (IsGrounded())
        {
            deltaX = CrossPlatformInputManager.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        }
        else
        {
            deltaX = CrossPlatformInputManager.GetAxis("Horizontal") * Time.deltaTime * jumpingMoveSpeed;
        }
        var newPosX = transform.position.x + deltaX;
        transform.position = new Vector2(newPosX, transform.position.y);
    
        if (CrossPlatformInputManager.GetAxis("Horizontal") < 0 && !flipping && PlayerPrefs.GetString("Equipped") != "0")
        {
            sprite.flipX = true;
            if (loadedHat != null)
            {
                hatSprite.flipX = true;
                if (!hatFlip)
                {
                    loadedHat.transform.position = new Vector3(loadedHat.transform.position.x + .4f, loadedHat.transform.position.y, loadedHat.transform.position.z);
                    hatFlip = true;
                }
            }
           
            
            
        }
        else
        {
            sprite.flipX = false;
            if (loadedHat != null)
            {
                hatSprite.flipX = false;
                if (hatFlip)
                {
                    loadedHat.transform.position = new Vector3(loadedHat.transform.position.x - .4f, loadedHat.transform.position.y, loadedHat.transform.position.z);
                    hatFlip = false;
                }
            }
           
        }
    }

    void CreateDust()
    {
        dust.Play();
    }

    void CreateDust2()
    {
        dust2.Play();
    }

    void CreateCDBDust()
    {
        CDBdust.Play();
    }

    void CreateGBDust()
    {
        GBDust.Play();
    }

    public void PauseGame()
    {
        PlayerPrefs.SetInt("gamePaused", 1);
        gameTime = Time.timeScale; 
        Time.timeScale = 0;
        pauseMenuUI.SetActive(true);
    }
    public void ResumeGame()
    {
        Time.timeScale = gameTime;
        pauseMenuUI.SetActive(false);
        optionsMenu.SetActive(false);
    }

    public void ButtonJump()
    {
        if (IsGrounded())
        {
            AudioSource.PlayClipAtPoint(jumpSound, Camera.main.transform.position);
            float jumpVel = 9f;
            rb.velocity = (Vector2.up * jumpVel);
            CreateDust();
            ScoreSaver.score.timesJumped++;
        }
        else
        {
            if (canDoubleJump)
            {
                AudioSource.PlayClipAtPoint(dJumpSound, Camera.main.transform.position);
                float jumpVel = 7f;
                rb.velocity = (Vector2.up * jumpVel);
                canDoubleJump = false;
                CreateDust2();
                ScoreSaver.score.timesJumped++;

                StartCoroutine(Flip(40));

            }
        }
    }

    public void ButtonAbility()
    {
        if (!IsGrounded() && stomp)
        {
            float stompVel = 15f;
            rb.velocity = (Vector2.down * stompVel);
            stomp = false;
            StartCoroutine(WaitGrounded());
        }
        else if (!IsGrounded() && burst)
            {
                Debug.Log("Burst function called");
                CreateCDBDust();
                AudioSource.PlayClipAtPoint(burstSound, Camera.main.transform.position);
                float burstVel = 7f;
                float upVel = 3;
                rb.velocity = (Vector2.right * burstVel) + (Vector2.up * upVel);
                burst = false;

            }
    }

 

}
