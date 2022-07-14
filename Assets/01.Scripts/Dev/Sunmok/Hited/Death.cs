using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    [SerializeField] BossHP HP;
    [SerializeField] BossHPViewer Viewer;
    private void OnEnable()
    {
        StartCoroutine(Viewer.SecondBossSpawn());
    }
    private void OnDisable()
    {

        Viewer.SecondBossDie();
    }
    private void Update()
    {
        if(HP.CurrentHP <= 0)
        {
            BossPa.Instance.die1();

            gameObject.SetActive(false);
        }
    }
}
