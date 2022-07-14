using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBullet : MonoBehaviour
{
    [SerializeField] private float speed; // �ӵ�

    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime, Space.Self); // �־��� ���⺤�ͷ� �̵�
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
