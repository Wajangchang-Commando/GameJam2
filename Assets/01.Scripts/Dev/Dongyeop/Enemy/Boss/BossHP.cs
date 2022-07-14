using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHP : MonoBehaviour //����HP slider�� �� �⺻���� HP�Դϴ�. ������ �־��ֽø� �˴ϴ�.
{
    [SerializeField] private int _maxHP = 300;

    public int bossHP; //public���� �ص����� HP�� 0�϶� ����Ǵ°� ���ֽø� �����ϰڽ��ϴ�. 

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
