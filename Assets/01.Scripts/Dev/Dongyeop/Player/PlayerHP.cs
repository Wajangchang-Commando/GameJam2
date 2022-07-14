using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHP : MonoBehaviour //�÷��̾ �� HP ��ũ��Ʈ�Դϴ�. 
{
    public int _maxHP = 10;
    public PlayerInvincibility invi;

    public int nowHP; //public���� �ص����� HP�� 0�϶� ����Ǵ°� ���ֽø� �����ϰڽ��ϴ�. 

    private void Update()
    {
        _maxHP = 10 + StatManager.Instance.HpAdv;
        nowHP = Mathf.Clamp(nowHP, -1, _maxHP);
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
        invi = GetComponent<PlayerInvincibility>();
    }
    

    public void TalkDamage(int damage)
    {
        nowHP -= damage;
        StartCoroutine(invi.Invincibility());
        if(nowHP <= 0)
        {
            SceneManager.LoadScene(2);
        }
    }
}
