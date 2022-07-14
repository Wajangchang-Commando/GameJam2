using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spread : MonoBehaviour
{
    GameObject core;
    Vector3 dir;
    float speed=4;
    float rotz;
    void Start()
    {
        rotz = transform.rotation.z;
        core = GameObject.Find("Ice_Core");
        dir = core.transform.position - transform.position;
        dir.Normalize();
    }
    void Update()
    {
        transform.position += -dir * speed * Time.deltaTime;
        core = GameObject.Find("Ice_Core");
        dir = core.transform.position - transform.position;
        dir.Normalize();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name.Contains("Player"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
