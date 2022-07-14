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

    void Update() //0.5초마다 소환 및 20번소환시 소멸
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
        //선생님께서 소환할때 Find 대신 써주신거
        Spread_Group ice = Instantiate(spreading).GetComponent<Spread_Group>();

        ice.transform.position = transform.position;
        ice.core = gameObject;

        createtime = 0;
    }
    private void OnTriggerEnter2D(Collider2D other) //플레이어랑 닿으면 사라지게(hp가 깎이도록 수정필요!!
    {
        if (other.gameObject.name.Contains("Player"))
        {
            other.GetComponent<PlayerHP>().TalkDamage(2);
            Destroy(gameObject);
        }
    }
}
