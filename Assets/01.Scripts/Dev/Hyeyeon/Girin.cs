using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Girin : MonoBehaviour
{
    [SerializeField] private Transform _player; // Player ����
    [SerializeField] private GameObject _bullet; // �Ѿ� ������Ʈ

    [SerializeField] private float timer; // Ÿ�̸�
    [SerializeField] private float waitingTime; // �Ѿ��� ������ ������ �ð�

    private void Start()
    {
        timer = 0.0f;
        waitingTime = 2f; // ������ �ð� 2��
    }

    private void Update()
    {
        timer += Time.deltaTime; // timer�� ������ ���������� �����.

        if(timer > waitingTime) // ���� timer�� waitingTime���� ũ�ٸ�
        {
            timer = 0; // timer�� 0���� �����.
            shot(); // shot�� �����Ѵ�.
        }
    }

    public void shot()
    {
        var bl = new List<Transform>(); // Player �������� �߻�� ������Ʈ ����

        for (int i = 0; i < 360; i += 13)
        {
            var temp = Instantiate(_bullet); // �Ѿ� ����

            Destroy(temp, 5f); // 5���� ����

            Vector2 positionsBullet = new Vector2(this.gameObject.transform.position.x, this.gameObject.transform.position.y);

            bl.Add(temp.transform); // ?���Ŀ� Player���� ���ư� ������Ʈ ����

            temp.transform.rotation = Quaternion.Euler(0, 0, i); // Z�� ���� ���ؾ� ȸ���� �̷�����Ƿ�, Z�� i�� �����Ѵ�.
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

            bl[i].rotation = Quaternion.Euler(0, 0, angle); // Target �������� �̵�
        }
        bl.Clear(); // ������ ����
    }
}
