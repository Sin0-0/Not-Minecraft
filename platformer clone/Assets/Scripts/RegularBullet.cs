using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegularBullet : MonoBehaviour
{
    public bool goingLeft;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {

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


}