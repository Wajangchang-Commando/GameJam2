using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ice_Core : MonoBehaviour
{
    [SerializeField]
    GameObject spreading;
    [SerializeField]
    Spread_Group ice;

    GameObject player;
    float createtime=8;
    int summonedtime=0;

    void Start()
    {
        player = GameObject.Find("Player");
        float playerx = player.transform.position.x;
        float playery = player.transform.position.y;
        //transform.position = new Vector3(Random.Range(playerx-5,playerx+5), Random.Range(playery - 5, playery + 5), 0);
    }
    void Update()
    {
        createtime += Time.deltaTime;
        if (createtime > 0.5f)
        {
            Summon();
            summonedtime += 1;
        }
        if(summonedtime > 20)
        {
            Destroy(gameObject);
        }
    }
    void Summon()
    {
        Spread_Group ice = Instantiate(spreading).GetComponent<Spread_Group>();

        ice.transform.position = transform.position;
        ice.core = gameObject;

        createtime = 0;
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
