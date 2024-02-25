using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickHomeScreen : MonoBehaviour
{
    [SerializeField] AudioSource click; 



    // Start is called before the first frame update
    void Start()
    {
        if (ScoreSaver.score.gameOpened)
        {
            click.Play();
        }
        else
        {
            ScoreSaver.score.gameOpened = true; 
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
