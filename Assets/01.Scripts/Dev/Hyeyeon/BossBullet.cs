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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player") // ���� �±װ� Player���
        {
            Destroy(collision.gameObject); // �� ������Ʈ�� �ı��Ѵ�.
            Destroy(gameObject); // �� �ڽŵ� �ı��Ѵ�.
        }
    }
}
