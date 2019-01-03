using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarScript : MonoBehaviour
{
    Rigidbody2D rb;
    public float moveSpeed;
    public GameManager gm; 

    public void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Zombie")
        {
            gm.IncrementPoints();
            Destroy(this.gameObject);
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = Vector2.left * moveSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -50f)
        {
            Debug.Log("object destroyed");
            Destroy(gameObject);
        }
    }
}
