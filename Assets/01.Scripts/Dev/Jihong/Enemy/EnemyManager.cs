using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    float currenttime = 0;
    float spawntime = 1.5f;
    [SerializeField]
    GameObject Enemy;
    [SerializeField]
    GameObject Enemy_Heart;
    float x, y;
    void Update()
    {
        x = Random.Range(-13f, 13f);
        y = Random.Range(-7f, 7f);
        transform.position = new Vector3(x, y, 0);
        currenttime += Time.deltaTime;
        if (currenttime > spawntime && Mathf.Abs(x) + 2*Mathf.Abs(y) >= 12.4f && Mathf.Abs(x) + 2*Mathf.Abs(y) <= 12.6f)
        {
            Summon(Random.Range(0, 2));
        }
    }
    void Summon(int forswitch)
    {
        switch (forswitch)
        {
            case 0:
                GameObject enemy=Instantiate(Enemy);
                enemy.transform.position = transform.position;
                break;
            case 1:
                GameObject enemy_heart = Instantiate(Enemy_Heart);
                enemy_heart.transform.position = transform.position;
                break;
        }
        currenttime = 0;
        spawntime = Random.Range(2f, 3f);
    }
}