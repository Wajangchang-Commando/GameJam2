using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBullet : MonoBehaviour
{
    [SerializeField] private float speed; // 속도

    Vector3 direction = Vector3.zero;

    void Update()
    {
        if (direction != Vector3.zero)
            transform.position += direction * speed * Time.deltaTime; // 주어진 방향벡터로 이동
    }

    public void SetDirection(Vector2 direction)
    {
        this.direction = direction;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player") // 만약 태그가 Player라면
        {
            Destroy(collision.gameObject); // 그 오브젝트를 파괴한다.
            Destroy(gameObject); // 나 자신도 파괴한다.
        }
    }
}
