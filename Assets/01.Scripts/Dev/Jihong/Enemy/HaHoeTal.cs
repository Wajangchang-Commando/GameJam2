using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HaHoeTal : MonoBehaviour
{
    Vector3 dir;
    float speed=1;
    GameObject target;
    void Start()
    {
        target = GameObject.Find("Player");
        dir = target.transform.position - transform.position;
        dir.Normalize();
    }
    void Update()
    {
        transform.position += dir*Time.deltaTime*speed;
        Move();
    }
    void Move()
    {
        dir = target.transform.position - transform.position;
        dir.Normalize();
    }
}
