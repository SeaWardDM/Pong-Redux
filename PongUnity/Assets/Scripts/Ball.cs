using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class Ball : MonoBehaviour
{
    public float movementSpeed;
    public Vector3 direction;
    public float maxXposition;
 


    // Update is called once per frame
    void Update()
    {
        Move();
        CheckBoundaries();
    }

    public void Move()
    {
        transform.position += direction * movementSpeed * Time.deltaTime;
    }

    public void Bounce(Vector3 newDirection)

    {
        direction = newDirection;
    }

    public void CheckBoundaries()
    {
        if(transform.position.x > maxXposition)
        {
            Scoreboard.Instance.GivePointToP1();
            BallSpawner.Instance.SpawnBall();
            Destroy(gameObject);
        }
        else if (transform.position.x < -maxXposition)
        {
            Scoreboard.Instance.GivePointToP2();
            BallSpawner.Instance.SpawnBall();
            Destroy(gameObject);
        }
    }
}

