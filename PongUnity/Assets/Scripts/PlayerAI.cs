using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAI : MonoBehaviour
{
    public Paddle LPaddle;
    Ball currentBall;
    public float distanceBuffer;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (currentBall == null)
        {
            FindBall();
        }
        else
        {
            FollowBall();
        }
    }

    void TrashTalk()
    {
        Debug.Log("GG EZ FF");
    }

   void FindBall()
    {
        if (currentBall == null)
        {
            currentBall = FindObjectOfType<Ball>();
        }
    }

    void FollowBall()
    {
        if (currentBall.transform.position.y > LPaddle.transform.position.y + distanceBuffer)
        {
            LPaddle.MoveUp();
        }
        else if(currentBall.transform.position.y < LPaddle.transform.position.y - distanceBuffer)
        {
            LPaddle.MoveDown();
        }
    }
}
