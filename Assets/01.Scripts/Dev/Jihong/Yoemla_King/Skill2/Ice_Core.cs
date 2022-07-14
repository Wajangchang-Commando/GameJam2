using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ice_Core : MonoBehaviour
{
    [SerializeField]
    GameObject spreading;
    [SerializeField]
    Spread_Group ice;
    float createtime=8;
    int summonedtime=0;

    void Update() //0.5�ʸ��� ��ȯ �� 20����ȯ�� �Ҹ�
    {
        createtime += Time.deltaTime;
        if (createtime > 0.5f)
        {
            Summon();
            summonedtime += 1;
        }
        if(summonedtime > 20)
        {
            Destroy(gameObject);
        }
    }
    void Summon()
    {
        //�����Բ��� ��ȯ�Ҷ� Find ��� ���ֽŰ�
        Spread_Group ice = Instantiate(spreading).GetComponent<Spread_Group>();

        ice.transform.position = transform.position;
        ice.core = gameObject;

        createtime = 0;
    }
    private void OnTriggerEnter2D(Collider2D other) //�÷��̾�� ������ �������(hp�� ���̵��� �����ʿ�!!
    {
        if (other.gameObject.name.Contains("Player"))
        {
            other.GetComponent<PlayerHP>().TalkDamage(2);
            Destroy(gameObject);
        }
    }
}
