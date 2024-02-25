using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] List<WaveConfig> waveConfigs;
    int startingWave = 0;
    [SerializeField] bool looping = true;
    [SerializeField] float timeWaited = 10f;
    [SerializeField] Score score;
    [SerializeField] int waveAmount;
    int wave = 0;
    float mult = .01f;
    float newTimeWaited;
    bool gamePaused = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            gamePaused = !gamePaused;
        }
    }

    // Start is called before the first frame update
    IEnumerator Start()
    {
        var currentWave = waveConfigs[startingWave];
        do
        {

            currentWave = waveConfigs[UnityEngine.Random.Range(0, waveConfigs.Count)];
            yield return StartCoroutine(SpawnAllEnemiesInWave(currentWave));
            newTimeWaited = timeWaited - (mult * score.GetCurrentScore());
            yield return new WaitForSeconds(newTimeWaited);




        }
        while (looping);
    }

    private IEnumerator SpawnAllEnemiesInWave(WaveConfig waveConfig)
    {
        for (int i = 0; i < waveConfig.GetNumOfEnimies(); i++)
        {
            Instantiate(waveConfig.GetEnemyPrefab(),
            waveConfig.GetWayPoints()[0].transform.position, Quaternion.identity);
            yield return new WaitForSeconds(waveConfig.GetTimeBetweenSpawns() * Time.deltaTime);
        }
    }
}


