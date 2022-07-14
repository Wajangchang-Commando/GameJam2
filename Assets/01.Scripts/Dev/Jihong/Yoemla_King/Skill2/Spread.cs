using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spread : MonoBehaviour  //얼음 움직임
{
    Vector3 dir;
    float speed=6;

    public void SetDerection(Vector3 direction)
    {
        dir = direction - transform.position;
        dir.Normalize();
    }

    void Update()
    {
        transform.position += -dir * speed * Time.deltaTime;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name.Contains("Player"))
        {
            other.GetComponent<PlayerHP>().TalkDamage(1);
            Destroy(gameObject);
        }
    }
}
