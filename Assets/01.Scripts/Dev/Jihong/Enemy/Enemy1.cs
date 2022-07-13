using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : MonoBehaviour
{
    [SerializeField]
    GameObject Hahoetal;
    Vector3 dir;
    float speed = 4;
    float x, y;
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
        dir.Normalize();
        x = transform.position.x;
        y=transform.position.y;
        if (!(Mathf.Abs(x) + 2 * Mathf.Abs(y) >= 12.4f && Mathf.Abs(x) + 2 * Mathf.Abs(y) <= 12.6f))
        { 
            transform.position = dir * Time.deltaTime * speed;
        }
    }
    IEnumerator Fire()
    {
        while (true)
        {
            GameObject Bullet = Instantiate(Hahoetal);
            Bullet.transform.position = transform.position;
            yield return new WaitForSeconds(Random.Range(1.5f,2f));
        }
    }
}
