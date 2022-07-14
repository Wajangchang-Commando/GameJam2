using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBulletNTN : MonoBehaviour
{
    [SerializeField] private float _speed = 10f;

    private void Update()
    {
        //�ι�° �Ķ���Ϳ� Space.World�� �������ν� Rotation�� ���� ���� ������ ������
        transform.Translate(Vector2.right * _speed * Time.deltaTime, Space.Self);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("asdf");
            collision.gameObject.GetComponent<PlayerHP>().TalkDamage(2);
            PoolManager.Instance.Returner(GetComponent<Poolable>());
        }
    }
}
