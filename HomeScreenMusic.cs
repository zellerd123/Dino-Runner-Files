using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeScreenMusic : MonoBehaviour
{
    private AudioSource _audioSource;
    private void Awake()
    {
      

    }
    // Start is called before the first frame update
    void Start()
    {
        if ((ScoreSaver.score.homePlayer == false))
        {
            _audioSource = GetComponent<AudioSource>();
            DontDestroyOnLoad(transform.gameObject);
            _audioSource.Play();
            ScoreSaver.score.homePlayer = true;
        }
        else
        {
            return;
        }

    }

    public void Destroy()
    {
        ScoreSaver.score.homePlayer = false;
        Destroy(GameObject.Find("Game Music"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
