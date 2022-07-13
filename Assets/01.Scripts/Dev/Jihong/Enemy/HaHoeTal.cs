using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HaHoeTal : MonoBehaviour
{
    public Vector3 dir;
    float speed=3;
    GameObject target;
    public int vanghyang =1;
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
        dir = vanghyang * (target.transform.position - transform.position);
        dir.Normalize();
    }
}
