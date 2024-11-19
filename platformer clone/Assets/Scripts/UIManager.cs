using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


/*
 * Author: [Heaps, Kat]
 * Date Created: [10/18/2024]
 * Last Updated: [10/22/2024]
 * [Will handle player movement and collision]
 */
public class UIManager : MonoBehaviour
{

    public Player player;
    public TMP_Text lifeScore;
    public TMP_Text livesScore;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        lifeScore.text = " HP :" + player.life;
        livesScore.text = "Lives :" + player.lives;
    }
}
