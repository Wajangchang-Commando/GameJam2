using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : MonoBehaviour
{
    public GameObject bulletPre;

    GameObject[] bossGirin;
    GameObject[] bullet;

    GameObject[] targetPool;

    void Start()
    {
        
    }

    private void Awake()
    {
        bossGirin = new GameObject[10];
        bullet = new GameObject[100];

        Generate();
    }

    void Generate()
    {
        for(int index = 0; index < bossGirin.Length; index++)
        {
            bullet[index] = Instantiate(bulletPre);
            bullet[index].SetActive(false);
        }
    }

    void Update()
    {
        
    }

    public GameObject Obj(string type)
    {
        switch(type)
        {
            case "bullet":
                targetPool = bullet;
                break;
        }

        for (int index = 0; index < targetPool.Length; index++)
        {
            if (!targetPool[index].activeSelf)
            {
                targetPool[index].SetActive(true);
                return targetPool[index];
            }
        }

        return null;
    }
}
