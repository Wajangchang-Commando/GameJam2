using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBound : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Knife"))
        {
            Debug.Log("ASdf");
            GetComponent<HaHoeTal>().vanghyang = -5;
        }
    }
}
