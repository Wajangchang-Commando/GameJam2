    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spread_Group : MonoBehaviour
{
    float currenttime;
    void Start()
    {
        transform.rotation = Quaternion.Euler(0, 0, Random.Range(0f, 45f));
    }
    private void Update()
    {
        currenttime += Time.deltaTime;
        if(currenttime > 5)
        {
            Destroy(gameObject);
        }
    }
}
