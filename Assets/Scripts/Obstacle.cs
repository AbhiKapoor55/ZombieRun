using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    Rigidbody2D rb;
    public float moveSpeed;

    public void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        rb.velocity = Vector2.left * moveSpeed; 
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < -50f)
        { 
            Debug.Log("object destroyed");
            Destroy(gameObject);
        }
    }
}
