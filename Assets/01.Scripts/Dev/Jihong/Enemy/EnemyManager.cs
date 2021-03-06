using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour //적 랜덤생성 코드
{
    public static EnemyManager instance;
    private void Awake()
    {
        instance = this;
    }
    public GameObject Summon1()
    {
        GameObject obj = PoolManager.Instance.Summon("Enemy1").gameObject;
        return obj;
    }
    public GameObject Summon2()
    {
        GameObject obj = PoolManager.Instance.Summon("Enemy2").gameObject;
        return obj;
    }
    public GameObject Summon3()
    {
        GameObject obj = PoolManager.Instance.Summon("Enemy3(Lion)").gameObject;
        return obj;
    }
    public GameObject Summon4()
    {
        GameObject obj = PoolManager.Instance.Summon("Enemy4(Girl)").gameObject;
        return obj;
    }
}
