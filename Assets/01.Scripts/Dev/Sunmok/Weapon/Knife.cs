using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knife : MonoBehaviour
{
    [SerializeField] SpriteRenderer SPR;
    [SerializeField] Vector3 point;
    [SerializeField] Animator animator;
    [SerializeField] private bool IsAttack;
    [SerializeField] private float angle;
    [SerializeField] private Transform firepos;
    [SerializeField] private PolygonCollider2D coll;
    void Update()
    {
        Gunturn();
        Slash();
    }

    void Slash()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (IsAttack == false)
            {
                IsAttack = true;
                animator.SetBool("Attacking", true);
                coll.enabled = true;
            }
        }
    }

    public void SlashEnd()
    {
        animator.SetBool("Attacking", false);
        coll.enabled = false;
        IsAttack = false;
    }

    void Gunturn()
    {
        point = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z + 10));

        Vector3 Rot = point - transform.position;

        if (Rot.x < 0)
        {
            SPR.flipY = false;
        }
        else
        {
            SPR.flipY = true;
        }
        Rot.Normalize();
        angle = Mathf.Atan2(Rot.y, Rot.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }
}
