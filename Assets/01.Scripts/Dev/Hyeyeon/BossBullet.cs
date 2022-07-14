using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBullet : MonoBehaviour
{
    [SerializeField] private float speed; // �ӵ�

    Vector3 direction = Vector3.zero;

    void Update()
    {
        if (direction != Vector3.zero)
            transform.position += direction * speed * Time.deltaTime; // �־��� ���⺤�ͷ� �̵�
    }

    public void SetDirection(Vector2 direction)
    {
        this.direction = direction;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.GetComponent<PlayerHP>().TalkDamage(2);
            PoolManager.Instance.Returner(GetComponent<Poolable>());
        }
    }
}
