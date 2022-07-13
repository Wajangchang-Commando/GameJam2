using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3 : MonoBehaviour
{
    float speed = 1;
    GameObject target;
    Vector3 dir;
    public float interacttime=0;
    void Start()
    {
        target = GameObject.Find("Player");
        dir = target.transform.position - transform.position;
    }
    void Update()
    {
        transform.position += dir * speed* Time.deltaTime;
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.name.Contains("Player"))
        {
            speed = 0.001f;
            interacttime += Time.deltaTime; ;
            if(interacttime > 1)
            {
                Destroy(collision.gameObject);
                Destroy(gameObject);
            }
        }
    }
}
