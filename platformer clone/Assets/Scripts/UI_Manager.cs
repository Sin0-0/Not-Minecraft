using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //accesses UI to code it
using TMPro;
/// <summary>
/// Sanaa Shahzad
/// 11/14/24
/// Deals with UI 
/// </summary>
public class UI_Manager : MonoBehaviour
{
    public TextMeshProUGUI healthPoints; //references TextMeshPro to affect the text
    public TextMeshProUGUI Lives; //references TextMeshPro to affect the text
    // Start is called before the first frame update
    public Health healthScript;
    public Player playerScript;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        healthPoints.text = "HealthPoints: " + healthScript.healthPoints;
        Lives.text = "Lives: " + playerScript.lives;
    }
}
