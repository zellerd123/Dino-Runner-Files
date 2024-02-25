using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] GameObject dino;
    [SerializeField] Slider slider;
    [SerializeField] GameObject gameMusic;

    // Start is called before the first frame update
    float offset;
    void Awake()
    {
        slider.value = ScoreSaver.score.gameVol;
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.position = new Vector3(0, dino.transform.position.y/4 + 1f, -10);
    }
}
