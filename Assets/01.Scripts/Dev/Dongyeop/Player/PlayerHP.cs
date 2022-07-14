using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHP : MonoBehaviour //플레이어에 들어갈 HP 스크립트입니다. 
{
    public int _maxHP = 10;

    public int nowHP; //public으로 해뒀으니 HP가 0일때 실행되는건 해주시면 감사하겠습니다. 

    private void Update()
    {
        _maxHP = 10 + StatManager.Instance.HpAdv;
    }
    public float MaxHP
    {
        get
        {
            return _maxHP;
        }
    }
    public float CurrentHP
    {
        get
        {
            return nowHP;
        }
    }

    private void Start()
    {
        nowHP = _maxHP;
    }

    public void TalkDamage(int damage)
    {
        nowHP -= damage;
    }
}
