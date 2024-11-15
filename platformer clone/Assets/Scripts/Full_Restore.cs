using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Sanaa Shahzad
/// 11/14/24
/// Deals with full restore HP + 100 HP
/// </summary>

public class Full_Restore : MonoBehaviour
{
    public Health script;
    private int x = 100;
    private int y;
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.GetComponent<Player>()) //check if collided with player
        {

            script.healthPoints = 99;
            y = script.healthPoints + x;
        }
         y = script.healthPoints;
    }
}
