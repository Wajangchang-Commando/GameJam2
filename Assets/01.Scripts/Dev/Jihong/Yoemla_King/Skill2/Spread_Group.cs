    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spread_Group : MonoBehaviour
{
    float currenttime;

    public GameObject core;

    void Start()
    {
        transform.rotation = Quaternion.Euler(0, 0, Random.Range(0f, 45f));

        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).GetComponent<Spread>()
                .SetDerection(core.transform.position);
        }
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
