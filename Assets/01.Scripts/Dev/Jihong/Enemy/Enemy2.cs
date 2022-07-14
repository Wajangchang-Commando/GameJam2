using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour //하트눈 움직임 
{
    Vector3 dir;
    float speed = 5;
    SpriteRenderer SPR;
    void Start()
    {
        SPR = GetComponent<SpriteRenderer>();
        GameObject target = GameObject.Find("Player");
        dir = target.transform.position - transform.position;
        dir.Normalize();
    }
    void Update()
    {
        GameObject target = GameObject.Find("Player");
        dir = target.transform.position - transform.position;
        dir.Normalize();
        if (dir.x > 0)
        {
            SPR.flipX = true;
        }
        else SPR.flipX = false;
        transform.position += dir*Time.deltaTime*speed;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.GetComponent<PlayerHP>().TalkDamage(1);
            PoolManager.Instance.Returner(GetComponent<Poolable>());
        }
    }
}
