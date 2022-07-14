using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHP : MonoBehaviour //말 그대로 에너미에 들어갈 HP, 풀링이 필요합니다.
{
    [SerializeField] private int _maxEnemyHP;

    private PoolManager _poolManager;
    [SerializeField]private int _curEnemyHP;

    private void Start()
    {
        _curEnemyHP = _maxEnemyHP;
    }

    private void Update()
    {
        if (_curEnemyHP <= 0)
            if(Random.Range(0,2) == 1)
            {
                Poolable obj = PoolManager.Instance.Summon("HPup");
                obj.transform.position = transform.position;
            }
            PoolManager.Instance.Returner(GetComponent<Poolable>());
    }

    public void EnemyAYA(int aya)
    {
        _curEnemyHP -= aya;
    }
}
