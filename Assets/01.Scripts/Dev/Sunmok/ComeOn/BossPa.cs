using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossPa : MonoBehaviour
{
    public GameObject Boss1;
    public GameObject Boss2;
    public GameObject Boss3;

    public SummonPlan Plan;
    public static BossPa Instance;

    public bool bossdie1;
    public bool bossdie2;
    public bool bossdie3;

    private void Awake()
    {
        Instance = this;
    }
    public void Spawn1()
    {
        Boss1.SetActive(true);
    }
    public void die1()
    {
        Plan.StopAllCoroutines();
        Plan.start2();
    }
    public void Spawn2()
    {
        Boss2.SetActive(true);
    }
    public void die2()
    {
        StartCoroutine(Plan.Patton3());
    }
    public void Spawn3()
    {
        Boss3.SetActive(true);
    }
    public void die3()
    {
        SceneManager.LoadScene(3);
    }
}
