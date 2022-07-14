using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPrecovery : MonoBehaviour  // �÷��̾ ȸ����Ű�� �����ۿ� �� �⺻���� ���
{
    private PlayerHP _playerHP;

    private void Awake()
    {
        _playerHP = GameObject.Find("Player").GetComponent<PlayerHP>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _playerHP.nowHP++;
        PoolManager.Instance.Returner(GetComponent<Poolable>());

    }
}
