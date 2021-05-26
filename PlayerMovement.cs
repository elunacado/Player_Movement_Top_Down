using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float MoveSpeed = 5f;
    public Rigidbody2D rb;

    Vector2 movement;
   
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

      
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * MoveSpeed * Time.fixedDeltaTime);

    }

    private void OnTriggerEnter2D(Collider2D col)
    {
//         if (col.transform.tag=="danger")
//         {
//             gameObject.GetComponent<Animator>().SetBool("Loud", true);
//         }
        
    }
}
