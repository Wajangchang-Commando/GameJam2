using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill_Manager : MonoBehaviour
{
    [SerializeField]
    GameObject Skill1;
    [SerializeField]
    GameObject Skill2;
    void Start()
    {
        StartCoroutine(coSkill1());
        StartCoroutine(coSkill2());
    }
    void Update()
    {
        
    }
    IEnumerator coSkill1()
    {
        while (true)
        {
            GameObject skill1 = Instantiate(Skill1);
            skill1.transform.position = transform.position;
            yield return new WaitForSeconds(11);
        }
    }
    IEnumerator coSkill2()
    {
        while (true)
        {
            GameObject skill2 = Instantiate(Skill2);
            Vector2 pos = new Vector2 (transform.position.x, transform.position.y);
            skill2.transform.position = pos;
            yield return new WaitForSeconds(1);
            Destroy(skill2);
            yield return new WaitForSeconds(4);
        }
    }
}
