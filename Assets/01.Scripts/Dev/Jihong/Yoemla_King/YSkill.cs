using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YSkill : MonoBehaviour //보스 스킬 소환 및 쿨타임 (a,b가 쿨타임)
{
    [SerializeField]
    GameObject GetSkill1;
    [SerializeField]
    GameObject GetSkill2;
    bool cooltime=true;
    float currenttime = 0;
    int a, b;
    int Cooltime;
    void Start()
    {
        a = 8;
        b = 16;
    }
    void Update()
    {
        if (cooltime) 
        { 
             Skill(Random.Range(1, 3));
        }
        if (!cooltime)
        {
            currenttime += Time.deltaTime;
            if(currenttime > Cooltime)
            {
                currenttime=0;
                cooltime = true;
            }
        }
    }
    void Skill(int used)
    {
        cooltime=false;
        switch (used)
        {
            case 1:
                Skill1();
                new WaitForSeconds(a);
                Cooltime = a;
                break;
            case 2:
                Skill2();
                new WaitForSeconds(b);
                Cooltime=b;
                break;
        }
    }
    void Skill1()
    {
        GameObject skill1=Instantiate(GetSkill1);
        skill1.transform.position = transform.position;
    }
   void Skill2()
    {
        GameObject skill2 = Instantiate(GetSkill2);
        GameObject player = GameObject.Find("Player");
        skill2.transform.position = new Vector3(player.transform.position.x,player.transform.position.y+4,player.transform.position.z);
    }
}
