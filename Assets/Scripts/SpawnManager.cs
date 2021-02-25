using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //We are going to spawn a game object, in this case an obstacle
    public GameObject ObstaclePrefab;
    private Vector3 SpawnPos= new Vector3(25,0,0);
    private float startDelay = 2;
    private float repeatRate = 2;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void SpawnObstacle()
    {

        Instantiate(ObstaclePrefab, SpawnPos, ObstaclePrefab.transform.rotation);

    }
}
