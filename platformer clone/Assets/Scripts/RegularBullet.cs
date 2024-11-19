using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

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


    //public bool goingLeft;
    //public float speed;


    //// Start is called before the first frame update
    //void Start()
    //{

    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    BulletMove();
    //    Shoot();
    //}
    //private void Shoot()
    //{
    //    if (Input.GetKey(KeyCode.F) && readyToShoot)
    //    {
    //        Debug.Log("F key is pressed");
    //        SpawnProjectile();

    //    }
    //}

    //private void BulletMove()
    //{
    //    if (goingLeft)
    //    {
    //        transform.position += Vector3.left * speed * Time.deltaTime;
    //    }
    //    else
    //    {

    //        transform.position += Vector3.right * speed * Time.deltaTime;
    //    }
    //}
    //private void SpawnProjectile()
    //{
    //    GameObject bullet = Instantiate(projectilePrefab, transform.position, transform.rotation);
    //    bullet.GetComponent<Bullet>().goingLeft = movingLeft;
    //}
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
        if (collision.gameObject.tag == "Wall")
        {
            Destroy(gameObject);
        }
    }


}