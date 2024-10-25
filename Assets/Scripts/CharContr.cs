using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharContr : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] private float moveSpeed;
    Vector2 movement;
    public Animator anmtr;
    bool facingRight = true;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anmtr = GetComponent<Animator>();

    }

    private void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        if (Input.GetButtonDown("Fire1"))
        {
            anmtr.SetTrigger("attack");
        }

    }

    private void FixedUpdate()
    {

        


        rb.MovePosition(rb.position + movement * moveSpeed * Time.deltaTime);

        if (movement.y != 0 || movement.x != 0)
        {
            anmtr.SetBool("isRunning", true);

        }
        else
        {
            anmtr.SetBool("isRunning", false);
        }

        if (movement.x < 0 && facingRight)
        {
            flip();
            facingRight = !facingRight;
        }
        else if (movement.x > 0 && !facingRight)
        {
            flip();
            facingRight = !facingRight;
        }


        void flip()
        {
            transform.Rotate(0, 180f, 0);
        }

    }
}