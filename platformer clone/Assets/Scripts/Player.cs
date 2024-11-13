using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private int life;
    private int lives;
    public float speed;
    public float jumpForce;
    private Rigidbody rb;
    private Vector3 startPos;
   




    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        startPos = transform.position;
    }

    
    void Update()
    {
        PlayerJump();
        
        if (transform.position.y < -20)
        {
            Respawn();
        }
        CheckAbove();
    }

    

    private void FixedUpdate()
    {
        PlayerMove();
    }

    private void Respawn()
    {
        lives--;
        transform.position = startPos;

        if (lives == 0)
        {
            SceneManager.LoadScene(0);
        }
    }

    private void PlayerJump()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            RaycastHit hit;
            // if the raycast returns something  then the player is touching the ground.
            if (Physics.Raycast(transform.position, Vector3.down, out hit, 1.5f))
            {
                Debug.Log("Touching the ground");
                rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            }


        }
    }
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.tag == "Portal")
        {
            
            startPos = other.gameObject.GetComponent<Portal>().spawnPoint.transform.position;

            
            transform.position = startPos;
        }
        if (other.gameObject.tag == "Portal2")
        {
            
            startPos = other.gameObject.GetComponent<Portal2>().spawnPoint2.transform.position;

            transform.position = startPos;
        }
        if (other.gameObject.tag == "Portal3")
        {
            
            startPos = other.gameObject.GetComponent<Portal3>().spawnPoint3.transform.position;

            transform.position = startPos;
        }
        if (other.gameObject.tag == "Enemy1")
        {
            Respawn();
        }
        if (other.gameObject.tag == "Enemy2")
        {
            Respawn();
        }


    }
    private void PlayerMove()
    {
        if (Input.GetKey(KeyCode.A))
        {
            
            rb.MovePosition(transform.position + Vector3.left * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            
            rb.MovePosition(transform.position + Vector3.right * speed * Time.deltaTime);
        }
    }

    private void CheckAbove()
    {
        RaycastHit hit;
        

        if (Physics.Raycast(transform.position, Vector3.up, out hit, 1f))
        {
            if (hit.collider.tag == "Enemy2")
            {
                Respawn();
            }
        }
    }
   
}
