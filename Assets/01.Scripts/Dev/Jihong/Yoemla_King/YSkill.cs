using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YSkill : MonoBehaviour
{
    [SerializeField]
    GameObject GetSkill1;
    [SerializeField]
    GameObject GetSkill2;
    [SerializeField]
    GameObject GetSkill3;
    bool cooltime=true;
    void Start()
    {

    }
    void Update()
    {
        if (cooltime) 
        { 
             Skill(Random.Range(1, 4));
        } 
    }
    void Skill(int used)
    {
        cooltime=false;
        switch (used)
        {
            case 1:
                Skill1();
                new WaitForSeconds(5);
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

    }
    void Skill3()
    {

    }
}
