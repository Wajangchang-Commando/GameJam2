using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yeomla_move : MonoBehaviour
{
    Vector3 dir;
    float speed = 1;
    float x, y;
    GameObject target;
    void Start()
    {
        target = GameObject.Find("Player");
        dir = target.transform.position - transform.position;
        dir.Normalize();
        StartCoroutine(Teleport());
    }
    void Update()
    {
        dir = target.transform.position - transform.position;
        x = dir.x;
        y = dir.y;
        dir.Normalize();
        transform.position += 2*dir*Time.deltaTime;
    }
    IEnumerator Teleport()
    {
        while (true)
        {
            if (!(Mathf.Abs(x) + Mathf.Abs(y) <= 7))
            {
                transform.position +=3 * dir;
                yield return new WaitForSeconds(3);
            }
            yield return new WaitForSeconds(0.1f);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Contains("Player"))
        {
            Destroy(collision.gameObject);
        }
    }
}