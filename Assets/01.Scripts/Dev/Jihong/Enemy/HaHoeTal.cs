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
        Vector2 direction = new Vector2(
        target.transform.position.x - transform.position.x,
        target.transform.position.y - transform.position.y
        );

        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        transform.localEulerAngles = new Vector3(0, 0, angle);
    }
    void Update()
    {
        transform.position += dir*Time.deltaTime*speed;
        Move();
        Vector2 direction = new Vector2(
        target.transform.position.x - transform.position.x,
        target.transform.position.y - transform.position.y
        );

        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        transform.localEulerAngles = new Vector3(0, 0, angle+180);
    }
    void Move()
    {
        dir = vanghyang * (target.transform.position - transform.position);
        dir.Normalize();
    }
}
