using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    public Vector3 dir;
    public int damage;
    void Update()
    {
        transform.position += dir * Time.deltaTime * speed;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            collision.GetComponent<EnemyHP>().EnemyAYA(damage);
            PoolManager.Instance.Returner(GetComponent<Poolable>());
        }
    }
}
