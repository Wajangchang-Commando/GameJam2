using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YSkill_Nfollow : MonoBehaviour   //Ä®¿òÁ÷ÀÓ (ufollow)
{
    float speed = 10;
    void Update()
    {
        transform.position += transform.TransformDirection(Vector3.left) * speed * Time.deltaTime;
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
