using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] SpriteRenderer SPR;
    [SerializeField]Vector3 point;
    void Update()
    {
        Gunturn();
    }
    void Gunturn()
    {
        point = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z +10));
        
        Vector3 Rot = point - transform.position;

        if (Rot.x < 0)
        {
            SPR.flipY = true;
        }
        else
        {
            SPR.flipY = false;
        }
        Rot.Normalize();
        float angle = Mathf.Atan2(Rot.y, Rot.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }
}
