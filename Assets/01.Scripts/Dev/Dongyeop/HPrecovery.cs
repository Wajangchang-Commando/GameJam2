using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPrecovery : MonoBehaviour  // 플레이어를 회복시키는 아이템에 들어갈 기본적인 기능
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
