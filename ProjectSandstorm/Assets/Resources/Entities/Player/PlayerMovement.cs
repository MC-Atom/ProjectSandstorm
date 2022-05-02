using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private BoxCollider2D coll;

    [SerializeField] private LayerMask jumpableGround; // Assigned in the editor under "Player"

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World!");
        rb = GetComponent<Rigidbody2D>();
        coll = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float dirX = Input.GetAxisRaw("Horizontal"); // Allows for joystick support
        rb.velocity = new Vector2(dirX * 7, rb.velocity.y);
        

        if(Input.GetButtonDown("Jump") && isGrounded()){
            rb.velocity = new Vector2(rb.velocity.x ,14f);
        }
    }

    private bool isGrounded(){
        return Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, 0f, Vector2.down, .1f, jumpableGround);
    }
}
