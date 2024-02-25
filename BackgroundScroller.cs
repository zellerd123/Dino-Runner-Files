using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    [SerializeField] float scrollSpeed = 0.5f;
    float speedChanger = .0775f;
    Material myMaterial;
    Vector2 offSet;
    // Start is called before the first frame update
    void Start()
    {
        myMaterial = GetComponent<Renderer>().material;
        offSet = new Vector2(scrollSpeed * speedChanger, 0f);
    }

    // Update is called once per frame
    void Update()
    {

        if (PlayerPrefs.GetInt("gamePaused") == 0)
        {
            myMaterial.mainTextureOffset += offSet * scrollSpeed * speedChanger * Time.deltaTime;
        }
            
    }
}
