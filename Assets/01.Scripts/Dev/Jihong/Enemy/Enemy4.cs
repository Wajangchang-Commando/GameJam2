using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy4 : MonoBehaviour // 탈걸(?) 움직임 및 공격
{
    [SerializeField]
    GameObject Hahoetal;
    Vector3 dir;
    float speed = 1.5f;
    float x, y;
    bool onFire = false;
    float onlyonce=0.5f;
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
                Poolable Bullet = PoolManager.Instance.Summon(Hahoetal.name);
                Bullet.transform.position = transform.position;
            }
            yield return new WaitForSeconds(2-onlyonce);
            onlyonce = 0;
        }
    }
}
