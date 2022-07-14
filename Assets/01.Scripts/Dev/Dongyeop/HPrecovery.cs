using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPrecovery : MonoBehaviour
{
    private PlayerHP _playerHP;

    private void Awake()
    {
        _playerHP = GameObject.Find("Player").GetComponent<PlayerHP>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        _playerHP.nowHP++;
        //PoolManager.Instance.Returner(GetComponent<Poolable>());
    }
}
