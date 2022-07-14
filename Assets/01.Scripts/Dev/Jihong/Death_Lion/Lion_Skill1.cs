using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lion_Skill1 : MonoBehaviour //책날리는거
{
    Vector3 dir;
    float speed = 7;
    float currenttime=0;
    void Start()
    {
        GameObject target = GameObject.Find("Player");
        dir = target.transform.position - transform.position;
        dir.Normalize();
    }
    void Update()
    {        
        transform.position += dir * Time.deltaTime * speed;
        currenttime+=Time.deltaTime;
        if(currenttime >= 15)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Contains("Player"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
