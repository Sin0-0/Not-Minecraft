using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterScript : MonoBehaviour
{
    public float moveSpeed;
    private Vector3 moveDir;
    public int lives = 3;
    public int healthPoints = 99;
    private Rigidbody rb;
    public float jump = 1;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate() //is called on a fixed interval of 50 times per second
    {


        //check for left input
        if (Input.GetKey(KeyCode.A))
        {
            moveDir = Vector3.left;
            //  transform.position += moveDir * moveSpeed * Time.deltaTime;
            rb.MovePosition(transform.position + moveDir * moveSpeed * Time.deltaTime);
        }

        //check for right input
        if (Input.GetKey(KeyCode.D))
        {
            moveDir = Vector3.right;
            //  transform.position += moveDir * moveSpeed * Time.deltaTime;
            rb.MovePosition(transform.position + moveDir * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jump, ForceMode.Impulse);
        }
    }

    private void LoseLives() {
        //lose lives
        lives--;
        if (lives <= 0)
        {
            SceneManager.LoadScene(1); //game over scene with buttons to restart 
        }
    }

    private void losehealthPoints()
    {
      //  if(//regular enemy)
     //       lives -= -15??
     //    if (//hard enemy)
     //       lives -= -35 ??
        //lose HP
        if (healthPoints <= 0)
        {
            SceneManager.LoadScene(1); // game over scene with buttons to restart
        }
    }
}
