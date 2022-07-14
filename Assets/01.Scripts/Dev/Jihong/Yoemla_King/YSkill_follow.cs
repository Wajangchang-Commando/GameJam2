using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YSkill_follow : MonoBehaviour
{
    Vector3 xpos,ypos;
    GameObject player;
    [SerializeField]
    GameObject sety;
    [SerializeField]
    GameObject setx;
    float currenttime;
    void Start()
    {
        
        player = GameObject.Find("Player");
        xpos = new Vector3(player.transform.position.x+10, player.transform.position.y );
        ypos = new Vector3(player.transform.position.x, player.transform.position.y - 10);
        setx.transform.position = xpos;
        sety.transform.position = ypos;

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
