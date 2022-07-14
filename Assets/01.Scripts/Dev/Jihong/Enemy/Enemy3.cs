using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3 : MonoBehaviour //사자 움직임 및 데미지
{
    float speed = 8;
    public int damage;
    GameObject target;
    Vector3 dir;
    public float interacttime=0;
    bool following=true;
    Animator anim;
    SpriteRenderer SPR;
    void Start()
    {
        target = GameObject.Find("Player");
        dir = target.transform.position - transform.position;
        dir.Normalize();
        SPR=  GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        transform.position += dir * speed* Time.deltaTime;
        if (following)
        {
            StartCoroutine(finding());        
        }
        else
        {
            StopCoroutine(finding());
        }
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.name.Contains("Player"))
        {
            following = false;
            speed = 0.001f;
            interacttime += Time.deltaTime;
            if(interacttime > 0.5)
            {
                anim.SetBool("Biting", true);
                collision.gameObject.GetComponent<PlayerHP>().TalkDamage(damage);
                interacttime = 0;
            }
        }
    }
    public void BiteEnd()
    {
        anim.SetBool("Biting", false);
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.name.Contains("Player"))
        {
            speed = 8;
            interacttime = 0;
            following = true;
        }
    }
    IEnumerator finding()
    {
        target = GameObject.Find("Player");
        dir = target.transform.position - transform.position;
        dir.Normalize();
        if(dir.x > 0)
        {
            SPR.flipX = true;
        }
        else
        {
            SPR.flipX = false;
        }
        yield return new WaitForSeconds(1);
        
    }
}
