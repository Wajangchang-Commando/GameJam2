using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lion_Skil2 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Contains("Player"))
        {
            Debug.Log("Triggered");
            Destroy(collision.gameObject);
        }
    }
}
