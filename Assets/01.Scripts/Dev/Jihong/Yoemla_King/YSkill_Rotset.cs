using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YSkill_Rotset : MonoBehaviour
{
    GameObject player;
    Vector3 dir;
    void Start()
    {
        player = GameObject.Find("Player");
        dir = player.transform.position - transform.position;
        dir.Normalize();
        Vector2 direction = new Vector2(
        player.transform.position.x - transform.position.x,
        player.transform.position.y - transform.position.y
 );

        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        transform.localEulerAngles = new Vector3(0, 0, angle-180);
    }
}
