using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField]
    float jumpForce = 6; 
    bool canJump = false;
    bool gameOver = false; 
    Animator anim;
    public GameManager gm; 

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && canJump && !gameOver)
        {
            Jump();
            canJump = false; 
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Ground")
        {
            canJump = true;  
        }
        else if(collision.gameObject.tag == "Obstacle")
        {
            gm.GameOver();
            Destroy(collision.gameObject);
            anim.Play("ZombieDeath");
            gameOver = true; 
        }
    }

    void Jump()
    {
        rb.velocity = Vector2.up * jumpForce;
    }
}
