using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPathing : MonoBehaviour
{
    [SerializeField] WaveConfig waveConfig;
    List<Transform> waypoints;
    [SerializeField] float moveSpeed = 2f;
    int waypointIndex = 0;
    float gameMoveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        gameMoveSpeed = moveSpeed; 
        waypoints = waveConfig.GetWayPoints();
        transform.position = waypoints[waypointIndex].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        if (PlayerPrefs.GetInt("gamePaused") == 1) 
        {
            
            gameMoveSpeed = 0;
        }
       else
        {
            gameMoveSpeed = moveSpeed;
        }
    }

    private void Move()
    {
        if (waypointIndex <= waypoints.Count -1)
        {
            var targetPos = waypoints[waypointIndex].transform.position;
            var movThisFrame = gameMoveSpeed * Time.deltaTime;
           
            transform.position =
                Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y), targetPos, movThisFrame);

            if (waypoints[waypointIndex].transform.position.x == transform.position.x
                && waypoints[waypointIndex].transform.position.y == transform.position.y)
            {
                waypointIndex++;
            }
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
