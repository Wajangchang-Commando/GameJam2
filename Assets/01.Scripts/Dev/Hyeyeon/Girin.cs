using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Girin : MonoBehaviour
{
    [SerializeField] private Transform _player;
    [SerializeField] private GameObject _bullet; // �Ѿ� ������Ʈ
    [SerializeField] private GameObject _bulletNTN; // �̤���#7344

    [SerializeField] private float timer; // Ÿ�̸�
    [SerializeField] private float waitingTime; // �Ѿ��� ������ ������ �ð�

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
        waitingTime = 2f; // ������ �ð� 2��

        StartCoroutine(Fire(10)); // shot�� �����Ѵ�.
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
        timer += Time.deltaTime; // timer�� ������ ���������� �����.

        if(timer > waitingTime) // ���� timer�� waitingTime���� ũ�ٸ�
        {
            timer = 0; // timer�� 0���� �����.
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

            var bullet = PoolManager.Instance.Summon(_bullet.name); // �Ѿ� ����

            bullet.transform.position = position;

            var target_dir = _player.transform.position - bullet.transform.position; // ���� �Ѿ��� ��ġ���� �÷����� ��ġ�� ���Ͱ��� �y���Ͽ� ������ ����
            var angle = Mathf.Atan2(target_dir.y, target_dir.x) * Mathf.Rad2Deg; // x,y�� ���� �����Ͽ� Z���� ������ ������. -> ~�� ������ ��
            bullet.transform.rotation = Quaternion.Euler(0, 0, angle - 90); // Target �������� �̵�

            bullet.GetComponent<BossBullet>().SetDirection(target_dir);
        }

        yield return new WaitForSeconds (5);
        StartCoroutine(shoot());
    }

    #region �� �����ϱ� �ȴ�. 
    private void shot()
    {
        bl.Clear();

        for (int i = 0; i < 360; i += 13)
        {
            var temp = PoolManager.Instance.Summon(_bullet.name); // �Ѿ� ����


            Vector2 positionsBullet = new Vector2(this.gameObject.transform.position.x, this.gameObject.transform.position.y);

            bl.Add(temp.transform); // ?���Ŀ� Player���� ���ư� ������Ʈ ����

            temp.transform.rotation = Quaternion.Euler(0, 0, i); // Z�� ���� ���ؾ� ȸ���� �̷�����Ƿ�, Z�� i�� �����Ѵ�.
            temp.transform.position = positionsBullet;

            Vector2 direction = (_player.transform.position - temp.transform.position).normalized;

            temp.GetComponent<BossBullet>().SetDirection(direction);
        }

        StartCoroutine(BulletToTarget(bl)); // �Ѿ��� Player �������� �̵���Ų��.
    }

    IEnumerator BulletToTarget(List<Transform> bl)
    {
        yield return new WaitForSeconds(0.5f); // 0.5�� �Ŀ� ����

        for (int i = 0; i < bl.Count; i++)
        {
            var target_dir = _player.transform.position - bl[i].position; // ���� �Ѿ��� ��ġ���� �÷����� ��ġ�� ���Ͱ��� �y���Ͽ� ������ ����

            var angle = Mathf.Atan2(target_dir.y, target_dir.x) * Mathf.Rad2Deg; // x,y�� ���� �����Ͽ� Z���� ������ ������. -> ~�� ������ ����

            bl[i].rotation = Quaternion.Euler(0, 0, angle - 1); // Target �������� �̵�
        }
        bl.Clear(); // ������ ����
    }
    #endregion


    private IEnumerator shoot()
    {
        for (int i = 0; i < 360; i += 13)
        {
            //�Ѿ� ����
            Poolable temp = PoolManager.Instance.Summon(_bulletNTN.name);

            //2�ʸ��� ����
            Vector2 positionsBullet = new Vector2(this.gameObject.transform.position.x, this.gameObject.transform.position.y);

            //Vector2 positionsBullet = new Vector2(this.gameObject.transform.position.x, this.gameObject.transform.position.y);

            //�Ѿ� ���� ��ġ�� (0,0) ��ǥ�� �Ѵ�.
            temp.transform.position = Vector2.zero;

            //Z�� ���� ���ؾ� ȸ���� �̷�����Ƿ�, Z�� i�� �����Ѵ�.
            temp.transform.rotation = Quaternion.Euler(0, 0, i);
            temp.transform.position = positionsBullet;
        }
        yield return new WaitForSeconds (5);
        StartCoroutine(Fire(10));
    }
}