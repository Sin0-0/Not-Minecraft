using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Sanaa Shahzad
/// 11/14/24
/// Deals with regular power ups
/// </summary>


public class PowerUp : MonoBehaviour
{
    public int powerUp = 10;
    public Health script;
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.GetComponent<Player>()) //check if collided with player
        {

            script.healthPoints += powerUp;
        }
    }

}