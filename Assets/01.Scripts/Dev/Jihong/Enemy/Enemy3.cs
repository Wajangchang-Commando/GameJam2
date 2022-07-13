using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3 : MonoBehaviour
{
    float speed = 8;
    GameObject target;
    Vector3 dir;
    public float interacttime=0;
    bool following=true;
    void Start()
    {
        target = GameObject.Find("Player");
        dir = target.transform.position - transform.position;
        dir.Normalize();
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
                Destroy(collision.gameObject);
                Destroy(gameObject);
            }
        }
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
        yield return new WaitForSeconds(1);
        
    }
}
