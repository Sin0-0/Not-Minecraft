using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot2 : MonoBehaviour
{

    public bool movingLeft;
    public bool readyToShoot;
    public GameObject projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Shoot()
    {
        if (Input.GetKey(KeyCode.F) && readyToShoot)
        {
            Debug.Log("F key is pressed");
            SpawnProjectile();
            StartCoroutine(Cooldown());
        }
    }

    private void SpawnProjectile()
    {
        if (!movingLeft)

        {
            GameObject regularBullet = Instantiate(projectilePrefab, transform.position, transform.rotation);
            regularBullet.GetComponent<RegularBullet>().goingLeft = movingLeft;
        }
        else if (movingLeft)
        {
            GameObject regularBullet = Instantiate(projectilePrefab, transform.position, transform.rotation);
            regularBullet.GetComponent<RegularBullet>().goingLeft = movingLeft;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Shoot();
    }

    IEnumerator Cooldown()
    {
        readyToShoot = false;
        yield return new WaitForSeconds(1);
        readyToShoot = true;
    }

}
