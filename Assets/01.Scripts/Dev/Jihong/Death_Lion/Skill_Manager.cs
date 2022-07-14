using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill_Manager : MonoBehaviour //사신 보스 스킬사용 및 사라짐
{
    [SerializeField]
    GameObject Skill1;
    [SerializeField]
    GameObject Skill2;

    GameObject player;

    [SerializeField]
    GameObject enemy;
    GameObject skill2;
    Vector3 dir;
    SpriteRenderer spriteRenderer;
    void Start()
    {
        player = GameObject.Find("Player");
        dir = enemy.transform.position - player.transform.position;
        dir.Normalize();
        StartCoroutine(coSkill1());
        StartCoroutine(coSkill2());
        spriteRenderer = enemy.GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        transform.rotation = player.transform.rotation;
        dir = enemy.transform.position - player.transform.position;
        dir.Normalize();
        enemy.transform.position += -dir*4*Time.deltaTime;
        if(skill2 != null)
        {
            skill2.transform.position = transform.position;
        }
        if (enemy.transform.position.x<=player.transform.position.x)
        {
            spriteRenderer.flipX = true;
        }
        else
        {
            spriteRenderer.flipX = false;
        }
    }
    IEnumerator coSkill1()
    {
        while (true)
        {
            GameObject skill1 = Instantiate(Skill1);

            Vector2 direction = new Vector2(
                player.transform.position.x - enemy.transform.position.x,
                player.transform.position.y - enemy.transform.position.y
         );

            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

            skill1.transform.position = transform.position;
            skill1.transform.localEulerAngles = new Vector3(0, 0, angle);

            yield return new WaitForSeconds(3);
        }
    }
    IEnumerator coSkill2()
    {
        while (true)
        {
            skill2 = Instantiate(Skill2);
            Vector2 pos = new Vector2 (transform.position.x, transform.position.y);
            skill2.transform.position = pos;
            yield return new WaitForSeconds(1);
            Destroy(skill2);
            yield return new WaitForSeconds(2.5f);
        }
    }
}
