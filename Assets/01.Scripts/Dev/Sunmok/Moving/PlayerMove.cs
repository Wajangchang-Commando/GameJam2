using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rigidbody;
    [SerializeField] private SpriteRenderer SPR;
    public float Speed;
    [SerializeField] private Animator animator;
    private void Update()
    {
        Move();
        Flip();
        MoveFix();
        if (PlayerSkillChanger.Instance.nowNum == 3)
        {
            Speed = 10 + StatManager.Instance.SpeAdv;
        }
        else Speed = 10;
    }
    void MoveFix()
    {
        float x = Mathf.Clamp(transform.position.x, -15, 14.5f);
        float y = Mathf.Clamp(transform.position.y, -9, 10);
        transform.position = new Vector3(x, y);
    }
    private void Move()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        rigidbody.velocity= new Vector3(x, y, 0)  * (Speed);
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
