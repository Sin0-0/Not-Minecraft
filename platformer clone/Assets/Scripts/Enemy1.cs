using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : MonoBehaviour
{


    private int EnemyLife;
    public GameObject leftPoint;
    public GameObject rightPoint;
    
    private Vector3 leftPos;
    private Vector3 rightPos;
    
    public float speed;
   
    public bool goingLeft;
    
    void Start()
    {
        leftPos = leftPoint.transform.position;
        rightPos = rightPoint.transform.position;
    }

    
    void Update()
    {
        EnemyMove();
    }

    private void EnemyMove()
    {
        if (goingLeft)
        {
            
            if (transform.position.x <= leftPos.x)
            {
                goingLeft = false;
            }
            else
            {
                transform.position += Vector3.left * speed * Time.deltaTime;
            }
        }
        else
        {
            
            if (transform.position.x >= rightPos.x)
            {
                goingLeft = true;
            }
            else
            {
                transform.position += Vector3.right * speed * Time.deltaTime;
            }
        }
    }


}
