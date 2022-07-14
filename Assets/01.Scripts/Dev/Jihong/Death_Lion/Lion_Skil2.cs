using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lion_Skil2 : MonoBehaviour //주변 영혼 아우라 소환
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Contains("Player"))
        {
            collision.GetComponent<PlayerHP>().TalkDamage(1);
        }
    }
}
