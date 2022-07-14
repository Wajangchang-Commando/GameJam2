using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ice_Core : MonoBehaviour
{
    [SerializeField]
    GameObject spreading;
    float createtime=8;
    void Start()
    {
    }
    void Update()
    {
        createtime += Time.deltaTime;
        if (createtime > 2)
        {
            Summon();
        }
    }
    void Summon()
    {
        GameObject ice = Instantiate(spreading);
        ice.transform.position = transform.position;
        createtime = 0;
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
