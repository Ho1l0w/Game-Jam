using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walking : MonoBehaviour
{
    public Animator animator;
    private Vector2 direction;
    private Rigidbody2D rb;
    public float runSpeed = 20.0f;
    public bool isMovable = true;
    public SpriteRenderer sprite;

    //для отключения ходьбы FindObjectOfType<ControlPerson>().isMovable = false;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (isMovable)
        {
            direction.x = Input.GetAxisRaw("Horizontal");
            direction.y = Input.GetAxisRaw("Vertical");

            if(direction.x != 0 || direction.y != 0)
            {
                if (direction.x > 0 )
                {
                    sprite.flipX = false;
                    
                }

                if (direction.x < 0)
                {
                    sprite.flipX = true;
                }
                animator.SetBool("isWalking", true);
            }
            else
            {
                animator.SetBool("isWalking", false);
            }

        }
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + direction * runSpeed * Time.fixedDeltaTime);
        
    }

}
