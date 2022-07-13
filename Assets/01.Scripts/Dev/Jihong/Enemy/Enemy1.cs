using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy1 : MonoBehaviour
{
    [SerializeField]
    GameObject Hahoetal;
    Vector3 dir;
    float speed = 1;
    [SerializeField]float x, y;
    bool onFire = true;
    void Start()
    {
        StartCoroutine(Fire());
        GameObject target = GameObject.Find("Player");
        dir = target.transform.position - transform.position;
        dir.Normalize();
    }
    void Update()
    {
        GameObject target = GameObject.Find("Player");
        dir = target.transform.position - transform.position;
        x = dir.x;
        y = dir.y;
        dir.Normalize();
        if ((Mathf.Abs(x) + 1.5f * Mathf.Abs(y) <= 10))
        {
            onFire = true;
        }
        else
        {
            transform.position += dir * Time.deltaTime * speed;
            onFire = false;
        }
    }
    IEnumerator Fire()
    {
        while (true)
        {
            if (onFire)
            {
                GameObject Bullet = Instantiate(Hahoetal);
                Bullet.transform.position = transform.position;
            }
            yield return new WaitForSeconds(Random.Range(1.5f, 2f));
        }
    }
}