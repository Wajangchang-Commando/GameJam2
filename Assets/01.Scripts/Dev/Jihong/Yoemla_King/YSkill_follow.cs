using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YSkill_follow : MonoBehaviour  //칼의 방향을 0/180 도로 정한뒤에 소환위치 설정
{
    Vector3 xpos,ypos;
    GameObject player;
    [SerializeField]
    GameObject sety;
    [SerializeField]
    GameObject setx;
    float currenttime;
    private void Awake()
    {
        float rotset = Random.Range(0, 2);
        Quaternion rot;
        if(rotset == 0)
        {
            rot = Quaternion.Euler(0, 0, 0);
        }
        else
        {
            rot =Quaternion.Euler(0, 0, 180);
        }
        transform.rotation = rot;
    }
    void Start()
    {        
        player = GameObject.Find("Player");
        if (transform.rotation.z == 0)
        {
            Debug.Log("Actived");
            xpos = new Vector3(player.transform.position.x + 10, player.transform.position.y);
            ypos = new Vector3(player.transform.position.x, player.transform.position.y + 10);
        }
        else
        {
            Debug.Log("Actived");
            xpos = new Vector3(player.transform.position.x - 10, player.transform.position.y);
            ypos = new Vector3(player.transform.position.x, player.transform.position.y - 10);
        }
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
