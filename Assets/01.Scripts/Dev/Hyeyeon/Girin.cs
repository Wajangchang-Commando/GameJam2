using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Girin : MonoBehaviour
{
    [SerializeField] private Transform _player;
    [SerializeField] private GameObject _bullet; // 총알 오브젝트
    [SerializeField] private GameObject _bulletNTN; // ㅜㅅㅜ#7344

    [SerializeField] private float timer; // 타이머
    [SerializeField] private float waitingTime; // 총알이 나오고 딜레이 시간

    private float speed;
    [SerializeField] BossHPViewer HPbar;
    [SerializeField] BossHP HP;

    List<Transform> bl = new List<Transform>();
    [SerializeField] private SpriteRenderer spriteRenderer;

    Vector3 dir;
    float x, y;
    bool onFire = false;

    private void Start()
    {
        timer = 0.0f;
        waitingTime = 2f; // 딜레이 시간 2초

        StartCoroutine(Fire(10)); // shot를 실행한다.
    }
    private void OnEnable()
    {
        StartCoroutine(HPbar.FirstBossSpawn());
    }
    private void OnDisable()
    {
        HPbar.FirstBossDie();
    }
    private void Update()
    {
        timer += Time.deltaTime; // timer를 일정한 프레임으로 만든다.

        if(timer > waitingTime) // 만약 timer가 waitingTime보다 크다면
        {
            timer = 0; // timer를 0으로 만든다.
        }
        
        dir = _player.transform.position - transform.position;
        x = dir.x;
        y = dir.y;
        dir.Normalize();
        if(HP.CurrentHP <= 0)
        {
            gameObject.SetActive(false);
        }

        if ((Mathf.Abs(x) + 1.5f * Mathf.Abs(y) <= 10))
        {
            onFire = true;
        }
        else
        {
            transform.position += dir * Time.deltaTime * speed;
            onFire = false;
        }

        if(dir.x > 0)
        {
            spriteRenderer.flipX = true;
        }
        else
        {
            spriteRenderer.flipX = false;
        }
    }

    private IEnumerator Fire(int count)
    {
        for (int i = 0; i < count + 1; i++)
        {
            float value = ((float)i / (float)count) * Mathf.PI * 2;

            Vector3 position = new Vector3(Mathf.Cos(value), Mathf.Sin(value)) * 2;
            position += transform.position;

            var bullet = PoolManager.Instance.Summon(_bullet.name); // 총알 생성

            bullet.transform.position = position;

            var target_dir = _player.transform.position - bullet.transform.position; // 현재 총알의 위치에서 플레이의 위치의 벡터값을 뻴셈하여 방향을 구함
            var angle = Mathf.Atan2(target_dir.y, target_dir.x) * Mathf.Rad2Deg; // x,y의 값을 조합하여 Z방향 값으로 변형함. -> ~도 단위로 변
            bullet.transform.rotation = Quaternion.Euler(0, 0, angle - 90); // Target 방향으로 이동

            bullet.GetComponent<BossBullet>().SetDirection(target_dir);
        }

        yield return new WaitForSeconds (5);
        StartCoroutine(shoot());
    }

    #region 아 개발하기 싫다. 
    private void shot()
    {
        bl.Clear();

        for (int i = 0; i < 360; i += 13)
        {
            var temp = PoolManager.Instance.Summon(_bullet.name); // 총알 생성


            Vector2 positionsBullet = new Vector2(this.gameObject.transform.position.x, this.gameObject.transform.position.y);

            bl.Add(temp.transform); // ?초후에 Player에게 날아갈 오브젝트 수록

            temp.transform.rotation = Quaternion.Euler(0, 0, i); // Z에 값이 변해야 회전이 이루어지므로, Z에 i를 대입한다.
            temp.transform.position = positionsBullet;

            Vector2 direction = (_player.transform.position - temp.transform.position).normalized;

            temp.GetComponent<BossBullet>().SetDirection(direction);
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

            bl[i].rotation = Quaternion.Euler(0, 0, angle - 1); // Target 방향으로 이동
        }
        bl.Clear(); // 데이터 해제
    }
    #endregion


    private IEnumerator shoot()
    {
        for (int i = 0; i < 360; i += 13)
        {
            //총알 생성
            Poolable temp = PoolManager.Instance.Summon(_bulletNTN.name);

            //2초마다 삭제
            Vector2 positionsBullet = new Vector2(this.gameObject.transform.position.x, this.gameObject.transform.position.y);

            //Vector2 positionsBullet = new Vector2(this.gameObject.transform.position.x, this.gameObject.transform.position.y);

            //총알 생성 위치를 (0,0) 좌표로 한다.
            temp.transform.position = Vector2.zero;

            //Z에 값이 변해야 회전이 이루어지므로, Z에 i를 대입한다.
            temp.transform.rotation = Quaternion.Euler(0, 0, i);
            temp.transform.position = positionsBullet;
        }
        yield return new WaitForSeconds (5);
        StartCoroutine(Fire(10));
    }
}