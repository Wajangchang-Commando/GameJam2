using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHP : MonoBehaviour
{
    [SerializeField] private int _maxEnemyHP;

    private PoolManager _poolManager;
    private int _curEnemyHP;

    private void Start()
    {
        _curEnemyHP = _maxEnemyHP;
    }

    private void Update()
    {
        if (_curEnemyHP <= 0)
            _poolManager.Returner(gameObject.GetComponent<Poolable>());
    }

    public void EnemyAYA(int aya)
    {
        _curEnemyHP -= aya;
    }
}
