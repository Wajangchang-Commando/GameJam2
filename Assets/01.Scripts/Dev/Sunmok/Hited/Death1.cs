using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death1 : MonoBehaviour
{
    [SerializeField] BossHP HP;
    [SerializeField] BossHPViewer Viewer;
    private void OnEnable()
    {
        StartCoroutine(Viewer.ThirdBossSpawn());
    }
    private void OnDisable()
    {
        Viewer.ThirdBossDie();
    }
    private void Update()
    {
        if(HP.CurrentHP <= 0)
        {
            gameObject.SetActive(false);
        }
    }
}
