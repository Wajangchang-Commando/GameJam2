using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBulletNTN : MonoBehaviour
{
    [SerializeField] private float _speed = 10f;

    private void Update()
    {
        //두번째 파라미터에 Space.World를 해줌으로써 Rotation에 의한 방향 오류를 수정함
        transform.Translate(Vector2.right * _speed * Time.deltaTime, Space.Self);
    }
}
