using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public static BallSpawner Instance;

    public Transform spawnPosition;
    public GameObject ballPrefab;

    GameObject currentBall;

    private void Awake()
    {
        Instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnBall();
        }
    }
    //Spawning Ball based on prefab
    public void SpawnBall()
    {
        currentBall = Instantiate(ballPrefab, spawnPosition.position, transform.rotation, null);

        int randX = Random.Range(0,2) * 2 -1;
        float randY = Random.Range(-1.5f, 1.5f);
        Vector3 newDirection = new Vector3(randX, randY, 0);

        //Apply new direction to ball
        currentBall.GetComponent<Ball>().direction = newDirection;
    }
    
}
