using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTester : MonoBehaviour
{
    // Start is called before the first frame update


    //plan for code:
    /* 
     create a bunch of functions that create individual waves
    have a random number generator that randomly chooses a function
    and able to store all the variables in enemyspawner like looping, timewaited,
    waveamount, mult, new time waited, etc.

    Note: continue to use the wave configs because the wave configs provide some benifit. NVM scratch that just make two lists. 
     
     
     */
    [SerializeField] List<GameObject> enemyPrefabs;
    [SerializeField] List<WaveConfig> waveConfigs;
    [SerializeField] bool looping = true;
    [SerializeField] float timeWaited = 1f;
    [SerializeField] float gameIncSpeed = .5f;
    int waves = 5;
    int randomWave;
    bool gamePaused = false;
    float gameTime = 1;
    int TorS;
    


   

    IEnumerator Start()
    {
        do
        {
           
                yield return new WaitForSeconds(timeWaited);
                randomWave = UnityEngine.Random.Range(1, waves + 1);//change the 1 after the comma back to waves after creating all the new characters
                if (randomWave == 1)
                {
                    StartCoroutine(Wave1());
                    yield return new WaitForSeconds(timeWaited * 5);
                }
                if (randomWave == 2)
                {
                    StartCoroutine(Wave2());
                    yield return new WaitForSeconds(timeWaited * 3);
                }
                if (randomWave == 3)
                {
                    StartCoroutine(Wave3());
                    yield return new WaitForSeconds(timeWaited * 3);
                }
                if (randomWave == 4)
                {
                    StartCoroutine(Wave4());
                    yield return new WaitForSeconds(timeWaited * 2.1f);
                }
                if (randomWave == 5)
                {
                    StartCoroutine(Wave5());
                    yield return new WaitForSeconds(timeWaited * 3.5f);
                }
                if (randomWave == 6)
                {
                    StartCoroutine(Wave6());
                    yield return new WaitForSeconds(timeWaited * 2.1f);
                }
                if (randomWave == 7)
                {
                    StartCoroutine(Wave7());
                    yield return new WaitForSeconds(timeWaited * 3.5f);
                }
                if (randomWave == 8)
                {
                    StartCoroutine(Wave8());
                    yield return new WaitForSeconds(timeWaited * 5.4f);
                }
                if (randomWave == 9)
                {
                    StartCoroutine(Wave9());
                    yield return new WaitForSeconds(timeWaited * 3f);
                }
                if (randomWave == 10)
                {
                    StartCoroutine(Wave10());
                    yield return new WaitForSeconds(timeWaited * 3f);
                }
                if (randomWave == 11)
                {
                    StartCoroutine(Wave11());
                    yield return new WaitForSeconds(timeWaited * 5.75f);
                }
                if (randomWave == 12)
                {
                    StartCoroutine(Wave12());
                    yield return new WaitForSeconds(timeWaited * 3.5f);
                }
                if (randomWave == 13)
                {
                    StartCoroutine(Wave13());
                    yield return new WaitForSeconds(timeWaited * 3.2f);
                }
                if (randomWave == 14)
                {
                    StartCoroutine(Wave14());
                    yield return new WaitForSeconds(timeWaited * 3.5f);
                }
            gameTime = gameTime + gameIncSpeed;
            Debug.Log("game time speed: " + gameTime);
            Debug.Log("game time speed inc: " + gameIncSpeed);
            Debug.Log("game time speed inc: "+ (gameTime + gameIncSpeed));
            Time.timeScale = gameTime;
            if (gameTime > 2)
            {
                waves = 14;
            }
            else if (gameTime > 1.6)
            {
                waves = 10;
            }
            else if (gameTime > 1.3)
            {
                waves = 7;
            }
            else
            {
                waves = 5;
            }

        }
        while (looping); 

    }

    IEnumerator Wave1()
    {
        for (int i = 0; i < 5; i++)
        {
            TorS = UnityEngine.Random.Range(1, 7);
            if (TorS == 1)
            {
                Instantiate(enemyPrefabs[0],
            waveConfigs[0].GetWayPoints()[0].transform.position, Quaternion.identity);
                yield return new WaitForSeconds(timeWaited);
            }
            else if (TorS == 2)
            {
                Instantiate(enemyPrefabs[8],
            waveConfigs[0].GetWayPoints()[0].transform.position, Quaternion.identity);
                yield return new WaitForSeconds(timeWaited);
            }
            else if (TorS == 3)
            {
                Instantiate(enemyPrefabs[9],
            waveConfigs[4].GetWayPoints()[0].transform.position, Quaternion.identity);
                yield return new WaitForSeconds(timeWaited);
            }
            else if (TorS == 4)
            {
                Instantiate(enemyPrefabs[10],
            waveConfigs[0].GetWayPoints()[0].transform.position, Quaternion.identity);
                yield return new WaitForSeconds(timeWaited);
            }
            else if (TorS == 5)
            {
                Instantiate(enemyPrefabs[11],
            waveConfigs[0].GetWayPoints()[0].transform.position, Quaternion.identity);
                yield return new WaitForSeconds(timeWaited);
            }
            else if (TorS == 6)
            {
                Instantiate(enemyPrefabs[5],
            waveConfigs[0].GetWayPoints()[0].transform.position, Quaternion.identity);
                yield return new WaitForSeconds(timeWaited);
            }


        }
        
    }


    IEnumerator Wave2()
    {
        Instantiate(enemyPrefabs[2],
            waveConfigs[0].GetWayPoints()[0].transform.position, Quaternion.identity);
        yield return new WaitForSeconds(1f);
        for (int i = 0; i < 5; i++)
        {
            Instantiate(enemyPrefabs[1],
            waveConfigs[0].GetWayPoints()[0].transform.position, Quaternion.identity);
            yield return new WaitForSeconds(.25f);
        }
        yield return new WaitForSeconds(1f);
        for (int i = 0; i < 2; i++)
        {
            Instantiate(enemyPrefabs[2],
           waveConfigs[0].GetWayPoints()[0].transform.position, Quaternion.identity);
            yield return new WaitForSeconds(.4f);
        }

    }

    IEnumerator Wave3()
    {
        for (int i = 0; i < 2; i++)
        {
            Instantiate(enemyPrefabs[0],
            waveConfigs[0].GetWayPoints()[0].transform.position, Quaternion.identity);
            yield return new WaitForSeconds(1.5f);
        }
        yield return new WaitForSeconds(1f);
        Instantiate(waveConfigs[1].GetEnemyPrefab(),waveConfigs[1].GetWayPoints()[0].transform.position, Quaternion.identity);
        Instantiate(enemyPrefabs[5], waveConfigs[0].GetWayPoints()[0].transform.position, Quaternion.identity);
        Debug.Log("waypoints :" + waveConfigs[1].GetWayPoints()[0].transform.position);
        for (int i = 0; i < 5; i++)
        {
   
                Instantiate(enemyPrefabs[4], waveConfigs[2].GetWayPoints()[0].transform.position, Quaternion.identity);
                Debug.Log("waypoint 2: " + waveConfigs[2].GetWayPoints()[0]);
                Debug.Log("waypoint 0: " + waveConfigs[0].GetWayPoints()[0]);
                Debug.Log("waypoint 1: " + waveConfigs[1].GetWayPoints()[0]);
                yield return new WaitForSeconds(.25f);

            
        }
        yield return new WaitForSeconds(.5f);
        Instantiate(enemyPrefabs[2],
           waveConfigs[0].GetWayPoints()[0].transform.position, Quaternion.identity);
    }

    IEnumerator Wave4()
    {
        Instantiate(enemyPrefabs[5],
            waveConfigs[0].GetWayPoints()[0].transform.position, Quaternion.identity);
        yield return new WaitForSeconds(.3f);
        Instantiate(enemyPrefabs[0],
            waveConfigs[0].GetWayPoints()[0].transform.position, Quaternion.identity);
        yield return new WaitForSeconds(1f);
        Instantiate(enemyPrefabs[5],
            waveConfigs[0].GetWayPoints()[0].transform.position, Quaternion.identity);
        for (int i = 0; i < 5; i++)
        {
            Instantiate(enemyPrefabs[5],
            waveConfigs[0].GetWayPoints()[0].transform.position, Quaternion.identity);
            yield return new WaitForSeconds(.3f);
        }
        Instantiate(enemyPrefabs[6],
            waveConfigs[1].GetWayPoints()[0].transform.position, Quaternion.identity);
        for (int i = 0; i < 5; i++)
        {
            Instantiate(enemyPrefabs[5],
            waveConfigs[0].GetWayPoints()[0].transform.position, Quaternion.identity);
            yield return new WaitForSeconds(.3f);
        }
        
        Instantiate(enemyPrefabs[7],
            waveConfigs[3].GetWayPoints()[0].transform.position, Quaternion.identity);

    }

    IEnumerator Wave5()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int k = 0; k < 3; k++)
            {
                Instantiate(enemyPrefabs[5],
           waveConfigs[0].GetWayPoints()[0].transform.position, Quaternion.identity);
                yield return new WaitForSeconds(.3f);
            }
            Instantiate(enemyPrefabs[5],
           waveConfigs[0].GetWayPoints()[0].transform.position, Quaternion.identity);
            yield return new WaitForSeconds(.3f);
            Instantiate(enemyPrefabs[5],
           waveConfigs[0].GetWayPoints()[0].transform.position, Quaternion.identity);
            yield return new WaitForSeconds(.3f);
            Instantiate(enemyPrefabs[3],
           waveConfigs[1].GetWayPoints()[0].transform.position, Quaternion.identity);
            yield return new WaitForSeconds(.3f);
            Instantiate(enemyPrefabs[5],
           waveConfigs[0].GetWayPoints()[0].transform.position, Quaternion.identity);
            yield return new WaitForSeconds(.3f);
            Instantiate(enemyPrefabs[5],
           waveConfigs[0].GetWayPoints()[0].transform.position, Quaternion.identity);
            yield return new WaitForSeconds(.3f);
        }
        yield return new WaitForSeconds(1f);
    }

    IEnumerator Wave6()
    {
        Instantiate(enemyPrefabs[9],
           waveConfigs[4].GetWayPoints()[0].transform.position, Quaternion.identity);
        yield return new WaitForSeconds(.3f);
        int mark = UnityEngine.Random.Range(1, 3);
        if (mark == 1)
        {
            Instantiate(enemyPrefabs[0],
            waveConfigs[0].GetWayPoints()[0].transform.position, Quaternion.identity);
            yield return new WaitForSeconds(.3f);
        }
        else
        {
            Instantiate(enemyPrefabs[2],
            waveConfigs[0].GetWayPoints()[0].transform.position, Quaternion.identity);
            yield return new WaitForSeconds(.3f);
        }
        mark = UnityEngine.Random.Range(1, 3);
        if (mark == 1)
        {
            Instantiate(enemyPrefabs[10],
            waveConfigs[0].GetWayPoints()[0].transform.position, Quaternion.identity);
            yield return new WaitForSeconds(.2f);
        }
        else
        {
            Instantiate(enemyPrefabs[11],
            waveConfigs[0].GetWayPoints()[0].transform.position, Quaternion.identity);
            yield return new WaitForSeconds(.2f);
        }
        Instantiate(enemyPrefabs[9],
          waveConfigs[4].GetWayPoints()[0].transform.position, Quaternion.identity);
        yield return new WaitForSeconds(.2f);
        Instantiate(enemyPrefabs[9],
           waveConfigs[4].GetWayPoints()[0].transform.position, Quaternion.identity);
        yield return new WaitForSeconds(1f);

    }

    IEnumerator Wave7()
    {
        for (int i = 0; i < 3; i++)
        {
            Instantiate(enemyPrefabs[8],
            waveConfigs[0].GetWayPoints()[0].transform.position, Quaternion.identity);
            yield return new WaitForSeconds(.25f);
        }

        Instantiate(waveConfigs[1].GetEnemyPrefab(), waveConfigs[1].GetWayPoints()[0].transform.position, Quaternion.identity);
        for (int i = 0; i < 5; i++)
        {

                Instantiate(enemyPrefabs[4], waveConfigs[2].GetWayPoints()[0].transform.position, Quaternion.identity);
                Debug.Log("waypoint 2: " + waveConfigs[2].GetWayPoints()[0]);
                Debug.Log("waypoint 0: " + waveConfigs[0].GetWayPoints()[0]);
                Debug.Log("waypoint 1: " + waveConfigs[1].GetWayPoints()[0]);
                yield return new WaitForSeconds(.25f);
            

        }
        yield return new WaitForSeconds(.5f);
        Instantiate(enemyPrefabs[2],
           waveConfigs[0].GetWayPoints()[0].transform.position, Quaternion.identity);
        yield return new WaitForSeconds(1f);
        Instantiate(enemyPrefabs[9],
           waveConfigs[4].GetWayPoints()[0].transform.position, Quaternion.identity);
    }

    IEnumerator Wave8()
    {
        for (int i = 0; i < 5; i++)
        {
            Instantiate(enemyPrefabs[5],
           waveConfigs[0].GetWayPoints()[0].transform.position, Quaternion.identity);
            yield return new WaitForSeconds(.3f);
        }
        Instantiate(enemyPrefabs[0],
           waveConfigs[0].GetWayPoints()[0].transform.position, Quaternion.identity);
        yield return new WaitForSeconds(.3f);
        for (int i = 0; i < 5; i++)
        {
            Instantiate(enemyPrefabs[5],
           waveConfigs[0].GetWayPoints()[0].transform.position, Quaternion.identity);
            yield return new WaitForSeconds(.3f);
        }
        Instantiate(enemyPrefabs[0],
           waveConfigs[0].GetWayPoints()[0].transform.position, Quaternion.identity);
        yield return new WaitForSeconds(.3f);
        for (int i = 0; i < 5; i++)
        {
            Instantiate(enemyPrefabs[5],
           waveConfigs[0].GetWayPoints()[0].transform.position, Quaternion.identity);
            yield return new WaitForSeconds(.3f);
        }
        Instantiate(enemyPrefabs[0],
           waveConfigs[0].GetWayPoints()[0].transform.position, Quaternion.identity);
        yield return new WaitForSeconds(.3f);
    }

    IEnumerator Wave9()
    {
        for (int i = 0; i < 3; i++)
        {
            Instantiate(enemyPrefabs[11],
            waveConfigs[0].GetWayPoints()[0].transform.position, Quaternion.identity);
            yield return new WaitForSeconds(.2f);
        }
        yield return new WaitForSeconds(1f);

        for (int i = 0; i < 5; i++)
        {
            Instantiate(enemyPrefabs[4], waveConfigs[2].GetWayPoints()[0].transform.position, Quaternion.identity);
            yield return new WaitForSeconds(.25f);
        }
        Instantiate(enemyPrefabs[9],
           waveConfigs[4].GetWayPoints()[0].transform.position, Quaternion.identity);

    }

    IEnumerator Wave10()
    {
        for (int i = 0; i < 2; i++)
        {
            Instantiate(enemyPrefabs[8],
            waveConfigs[0].GetWayPoints()[0].transform.position, Quaternion.identity);
            yield return new WaitForSeconds(.25f);
        }
        yield return new WaitForSeconds(.5f);
        Instantiate(enemyPrefabs[10],
            waveConfigs[0].GetWayPoints()[0].transform.position, Quaternion.identity);
        yield return new WaitForSeconds(.25f);
        for (int i = 0; i < 5; i++)
        {
            Instantiate(enemyPrefabs[1], waveConfigs[0].GetWayPoints()[0].transform.position, Quaternion.identity);
            yield return new WaitForSeconds(.25f);
        }
        
         Instantiate(enemyPrefabs[9],
         waveConfigs[4].GetWayPoints()[0].transform.position, Quaternion.identity);
         yield return new WaitForSeconds(.35f);

        
    }

    IEnumerator Wave11()
    {
        for (int i = 0; i < 5; i++)
        {
            Instantiate(enemyPrefabs[5],
            waveConfigs[0].GetWayPoints()[0].transform.position, Quaternion.identity);
            yield return new WaitForSeconds(.25f);
        }
        yield return new WaitForSeconds(.25f);
        Instantiate(enemyPrefabs[9],
        waveConfigs[4].GetWayPoints()[0].transform.position, Quaternion.identity);
        yield return new WaitForSeconds(.5f);
        for (int i = 0; i < 3; i++)
        {
            Instantiate(enemyPrefabs[0],
            waveConfigs[0].GetWayPoints()[0].transform.position, Quaternion.identity);
            yield return new WaitForSeconds(.25f);
            for (int k = 0; k < 5; k++)
            {
                int rand = UnityEngine.Random.Range(0, 8);
                if (rand == 0)
                {
                    Instantiate(enemyPrefabs[8],
            waveConfigs[0].GetWayPoints()[0].transform.position, Quaternion.identity);
                    yield return new WaitForSeconds(.25f);
                }
                else
                {
                    Instantiate(enemyPrefabs[1],
           waveConfigs[0].GetWayPoints()[0].transform.position, Quaternion.identity);
                    yield return new WaitForSeconds(.25f);
                }

            }
        }
    }

    IEnumerator Wave12()
    {
        int rand = UnityEngine.Random.Range(1, 5);
        for (int i = 0; i < rand; i++)
        {
            Instantiate(enemyPrefabs[2],
            waveConfigs[0].GetWayPoints()[0].transform.position, Quaternion.identity);
            yield return new WaitForSeconds(.25f);
        }
        yield return new WaitForSeconds(.25f);
        Instantiate(enemyPrefabs[8],
            waveConfigs[0].GetWayPoints()[0].transform.position, Quaternion.identity);
        yield return new WaitForSeconds(.25f);
        Instantiate(enemyPrefabs[11],
            waveConfigs[0].GetWayPoints()[0].transform.position, Quaternion.identity);
        yield return new WaitForSeconds(1f);
        rand = UnityEngine.Random.Range(3, 7);
        for (int i = 0; i < rand; i++)
        {
            Instantiate(enemyPrefabs[9],
            waveConfigs[4].GetWayPoints()[0].transform.position, Quaternion.identity);
            yield return new WaitForSeconds(.25f);
        }

    }

    IEnumerator Wave13()
    {
        for (int i = 0; i < 5; i++)
        {
            Instantiate(enemyPrefabs[5],
            waveConfigs[0].GetWayPoints()[0].transform.position, Quaternion.identity);
            yield return new WaitForSeconds(.3f);
        }
        Instantiate(enemyPrefabs[0],
            waveConfigs[0].GetWayPoints()[0].transform.position, Quaternion.identity);
            yield return new WaitForSeconds(1.5f);
        Instantiate(enemyPrefabs[8],
            waveConfigs[0].GetWayPoints()[0].transform.position, Quaternion.identity);
        yield return new WaitForSeconds(.3f);
        Instantiate(enemyPrefabs[9],
            waveConfigs[4].GetWayPoints()[0].transform.position, Quaternion.identity);
    }

    IEnumerator Wave14()
    {
        for (int i = 0; i < 4; i++)
        {
            Instantiate(enemyPrefabs[5],
            waveConfigs[0].GetWayPoints()[0].transform.position, Quaternion.identity);
            yield return new WaitForSeconds(.3f);
        }
        Instantiate(enemyPrefabs[1],
           waveConfigs[0].GetWayPoints()[0].transform.position, Quaternion.identity);
        yield return new WaitForSeconds(.4f);
        for (int i = 0; i < 3; i++)
        {
            Instantiate(enemyPrefabs[5],
            waveConfigs[0].GetWayPoints()[0].transform.position, Quaternion.identity);
            yield return new WaitForSeconds(.3f);
        }
        for (int i = 0; i < 2; i++)
        {
            Instantiate(enemyPrefabs[1],
            waveConfigs[0].GetWayPoints()[0].transform.position, Quaternion.identity);
            yield return new WaitForSeconds(.3f);
        }
        Instantiate(enemyPrefabs[5],
            waveConfigs[0].GetWayPoints()[0].transform.position, Quaternion.identity);
        yield return new WaitForSeconds(1.5f);
        Instantiate(enemyPrefabs[9],
            waveConfigs[4].GetWayPoints()[0].transform.position, Quaternion.identity);

    }

}
