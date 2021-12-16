using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 500f;

    public Rigidbody2D rb;
    public Animator animator;
    Vector2 movement;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time%2<0.2f){
            movement.x = Random.Range(-1,2);
            movement.y = Random.Range(-1,2);
        }
        else{
            movement.x = 0;
            movement.y = 0;
        }
        
    }
    void FixedUpdate() {
        move(movement);
    }
    void move(Vector2 movement){
        rb.MovePosition(rb.position + movement * moveSpeed * Time.deltaTime);
    }
}

