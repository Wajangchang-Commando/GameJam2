using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Girin : MonoBehaviour
{
    [SerializeField] private Transform _player; // Player 변수
    [SerializeField] private GameObject _bullet; // 총알 오브젝트

    [SerializeField] private float timer; // 타이머
    [SerializeField] private float waitingTime; // 총알이 나오고 딜레이 시간

    private void Start()
    {
        timer = 0.0f;
        waitingTime = 2f; // 딜레이 시간 2초
    }

    private void Update()
    {
        timer += Time.deltaTime; // timer를 일정한 프레임으로 만든다.

        if(timer > waitingTime) // 만약 timer가 waitingTime보다 크다면
        {
            timer = 0; // timer를 0으로 만든다.
            shot(); // shot를 실행한다.
        }
    }

    public void shot()
    {
        var bl = new List<Transform>(); // Player 방향으로 발사될 오브젝트 수록

        for (int i = 0; i < 360; i += 13)
        {
            var temp = Instantiate(_bullet); // 총알 생성

            Destroy(temp, 5f); // 5초후 삭제

            Vector2 positionsBullet = new Vector2(this.gameObject.transform.position.x, this.gameObject.transform.position.y);

            bl.Add(temp.transform); // ?초후에 Player에게 날아갈 오브젝트 수록

            temp.transform.rotation = Quaternion.Euler(0, 0, i); // Z에 값이 변해야 회전이 이루어지므로, Z에 i를 대입한다.
        }
        StartCoroutine(BulletToTarget(bl)); // 총알을 Player 방향으로 이동시킨다.
    }

    IEnumerator BulletToTarget(List<Transform> bl)
    {
        yield return new WaitForSeconds(0.5f); // 0.5초 후에 시작

        for (int i = 0; i < bl.Count; i++)
        {
            var target_dir = _player.transform.position - bl[i].position; // 현재 총알의 위치에서 플레이의 위치의 벡터값을 뻴셈하여 방향을 구함

            var angle = Mathf.Atan2(target_dir.y, target_dir.x) * Mathf.Rad2Deg; // x,y의 값을 조합하여 Z방향 값으로 변형함. -> ~도 단위로 변형

            bl[i].rotation = Quaternion.Euler(0, 0, angle); // Target 방향으로 이동
        }
        bl.Clear(); // 데이터 해제
    }
}
