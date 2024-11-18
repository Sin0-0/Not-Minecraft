using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Sanaa Shahzad
/// 11/17/24
/// Deals with heavy bullets, different from regular bullets
/// </summary>

public class HeavyBullet : MonoBehaviour
{
    public bool goingLeft;
    public float speed;
    private Vector3 StartPos;
    public GameObject StartPoint;

    // Start is called before the first frame update
    void Start()
    {
        StartPos = StartPoint.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        BulletMove();
    }



    private void BulletMove()
    {
        if (goingLeft)
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        else
        {

            transform.position += Vector3.right * speed * Time.deltaTime;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy2")
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "Enemy1")
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {

         //   Destroy(other.gameObject.tag == "Regular Bullet"); //destroy regular bullets


    //        transform.position = "StartPos"; //startPos is where the regular bullets were
        }
    }
}