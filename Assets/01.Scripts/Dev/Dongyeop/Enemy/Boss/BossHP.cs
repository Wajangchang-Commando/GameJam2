using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHP : MonoBehaviour //보스HP slider에 들어갈 기본적인 HP입니다. 보스에 넣어주시면 됩니다.
{
    [SerializeField] private int _maxHP = 300;

    public int bossHP; //public으로 해뒀으니 HP가 0일때 실행되는건 해주시면 감사하겠습니다. 

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
            return bossHP;
        }
    }

    private void Start()
    {
        bossHP = _maxHP;
    }

    public void TalkDamage(int damage)
    {
        bossHP -= damage;
    }
}
