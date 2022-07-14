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
    }
}
