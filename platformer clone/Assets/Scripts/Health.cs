using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Sanaa Shahzad
/// 11/14/24
/// Deals with Health
/// </summary>

public class Health : MonoBehaviour
{
    public int healthPoints = 99;
    private void OnCollisionEnter(Collision collision) { 
   
     if(collision.gameObject.GetComponent<Player>()) //check if collided with player
        {
        healthPoints += 10;
        }
        if (collision.gameObject.tag == "Enemy1") //check if collided with player
        {
            healthPoints -= 15;
        }
        if (collision.gameObject.tag == "Enemy2") //check if collided with player
        {
            healthPoints -= 35; 
        }
    }
}
