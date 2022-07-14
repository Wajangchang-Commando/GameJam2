using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public int Damage = 1;
    [SerializeField] private int Count = 3;

    public void Setting()
    {
        Damage = 1;
        Count = 3;
        GetComponent<Rigidbody2D>().velocity = Vector2.zero;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            collision.GetComponent<EnemyHP>().EnemyAYA(Damage);
            Count--;
        }
        if (collision.CompareTag("Boss"))
        {
            collision.GetComponent<BossHP>().TalkDamage(Damage);
            Count--;
        }
        if(Count < 1)
        {
            PoolManager.Instance.Returner(gameObject.GetComponent<Poolable>());
        }
    }
}
