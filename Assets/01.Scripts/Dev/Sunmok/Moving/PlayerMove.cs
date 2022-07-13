using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rigidbody;
    [SerializeField] private SpriteRenderer SPR;
    [SerializeField] private float Speed;
    [SerializeField] private Animator animator;
    private void Update()
    {
        Move();
        Flip();
    }
    private void Move()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        rigidbody.velocity= new Vector3(x, y, 0)  * Speed;
    }
    private void Flip()
    {
        if(rigidbody.velocity.x == Speed)
        {
            SPR.flipX = false;
        }
        if(rigidbody.velocity.x == -Speed)
        {
            SPR.flipX=true;
        }
    }
}
