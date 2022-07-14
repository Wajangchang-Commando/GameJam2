using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SummonPlan : MonoBehaviour
{
    [SerializeField] Transform point1;
    [SerializeField] Transform point2;
    [SerializeField] Transform point3;
    [SerializeField] Transform point4;
    [SerializeField] BossPa  bosys;

    private void Start()
    {
        StartCoroutine(Patton1());
    }
    public IEnumerator Patton1()
    {
        GameObject obj = EnemyManager.instance.Summon1();
        obj.transform.position = point1.position;
        obj = EnemyManager.instance.Summon1();
        obj.transform.position = point2.position;
        obj = EnemyManager.instance.Summon2();
        obj.transform.position = point3.position;
        obj = EnemyManager.instance.Summon1();
        obj.transform.position = point4.position;
        yield return new WaitForSeconds(1f);
        obj = EnemyManager.instance.Summon2();
        obj.transform.position = point1.position;
        obj = EnemyManager.instance.Summon2();
        obj.transform.position = point2.position;
        obj = EnemyManager.instance.Summon2();
        obj.transform.position = point3.position;
        obj = EnemyManager.instance.Summon1();
        obj.transform.position = point4.position;
        yield return new WaitForSeconds(3f);
        obj = EnemyManager.instance.Summon2();
        obj.transform.position = point1.position;
        obj = EnemyManager.instance.Summon1();
        obj.transform.position = point2.position;
        obj = EnemyManager.instance.Summon2();
        obj.transform.position = point3.position;
        obj = EnemyManager.instance.Summon1();
        obj.transform.position = point4.position;
        yield return new WaitForSeconds(3f);
        obj = EnemyManager.instance.Summon1();
        obj.transform.position = point1.position;
        obj = EnemyManager.instance.Summon1();
        obj.transform.position = point2.position;
        obj = EnemyManager.instance.Summon2();
        obj.transform.position = point3.position;
        obj = EnemyManager.instance.Summon1();
        obj.transform.position = point4.position;
        yield return new WaitForSeconds(1f);
        obj = EnemyManager.instance.Summon2();
        obj.transform.position = point1.position;
        obj = EnemyManager.instance.Summon2();
        obj.transform.position = point2.position;
        obj = EnemyManager.instance.Summon2();
        obj.transform.position = point3.position;
        obj = EnemyManager.instance.Summon1();
        obj.transform.position = point4.position;
        yield return new WaitForSeconds(1f);
        obj.transform.position = point1.position;
        obj = EnemyManager.instance.Summon1();
        obj.transform.position = point2.position;
        obj = EnemyManager.instance.Summon2();
        obj.transform.position = point3.position;
        obj = EnemyManager.instance.Summon1();
        obj.transform.position = point4.position;
        yield return new WaitForSeconds(1f);
        obj = EnemyManager.instance.Summon1();
        obj.transform.position = point1.position;
        obj = EnemyManager.instance.Summon2();
        obj.transform.position = point2.position;
        obj = EnemyManager.instance.Summon1();
        obj.transform.position = point3.position;
        obj = EnemyManager.instance.Summon2();
        obj.transform.position = point4.position;
        yield return new WaitForSeconds(1f);
        obj = EnemyManager.instance.Summon2();
        obj.transform.position = point1.position;
        obj = EnemyManager.instance.Summon1();
        obj.transform.position = point2.position;
        obj = EnemyManager.instance.Summon2();
        obj.transform.position = point3.position;
        obj = EnemyManager.instance.Summon2();
        obj.transform.position = point4.position;
        yield return new WaitForSeconds(1f);
        obj.transform.position = point1.position;
        obj = EnemyManager.instance.Summon1();
        obj.transform.position = point2.position;
        obj = EnemyManager.instance.Summon1();
        obj.transform.position = point3.position;
        obj = EnemyManager.instance.Summon2();
        obj.transform.position = point4.position;
        yield return new WaitForSeconds(1f);
        bosys.Spawn1();
        yield return null;
    }
    public void start2()
    {
        StopAllCoroutines();
        StartCoroutine(Patton2());
    }
    public IEnumerator Patton2()
    {
        Debug.Log("asdf");
        GameObject obj = EnemyManager.instance.Summon2();
        Debug.Log("asdf2");
        obj.transform.position = point1.position;
        obj = EnemyManager.instance.Summon4();
        obj.transform.position = point2.position;
        obj = EnemyManager.instance.Summon2();
        obj.transform.position = point3.position;
        obj = EnemyManager.instance.Summon4();
        obj.transform.position = point4.position;
        yield return new WaitForSeconds(1f);
        obj = EnemyManager.instance.Summon2();
        Debug.Log("asdf2");

        obj.transform.position = point1.position;
        obj = EnemyManager.instance.Summon4();
        obj.transform.position = point2.position;
        obj = EnemyManager.instance.Summon4();
        obj.transform.position = point3.position;
        obj = EnemyManager.instance.Summon4();
        obj.transform.position = point4.position;
        yield return new WaitForSeconds(1f);
        obj = EnemyManager.instance.Summon2();
        Debug.Log("asdf2");

        obj.transform.position = point1.position;
        obj = EnemyManager.instance.Summon2();
        obj.transform.position = point2.position;
        obj = EnemyManager.instance.Summon4();
        obj.transform.position = point3.position;
        obj = EnemyManager.instance.Summon2();
        obj.transform.position = point4.position;
        yield return new WaitForSeconds(1f);
        obj = EnemyManager.instance.Summon2();
        Debug.Log("asdf2");

        obj.transform.position = point1.position;
        obj = EnemyManager.instance.Summon4();
        obj.transform.position = point2.position;
        obj = EnemyManager.instance.Summon2();
        obj.transform.position = point3.position;
        obj = EnemyManager.instance.Summon2();
        obj.transform.position = point4.position;
        yield return new WaitForSeconds(1f);
        obj = EnemyManager.instance.Summon2();
        Debug.Log("asdf2");

        obj.transform.position = point1.position;
        obj = EnemyManager.instance.Summon4();
        obj.transform.position = point2.position;
        obj = EnemyManager.instance.Summon2();
        obj.transform.position = point3.position;
        obj = EnemyManager.instance.Summon4();
        obj.transform.position = point4.position;
        yield return new WaitForSeconds(1f);
        obj = EnemyManager.instance.Summon2();
        Debug.Log("asdf2");

        obj.transform.position = point1.position;
        obj = EnemyManager.instance.Summon4();
        obj.transform.position = point2.position;
        obj = EnemyManager.instance.Summon4();
        obj.transform.position = point3.position;
        obj = EnemyManager.instance.Summon2();
        obj.transform.position = point4.position;
        yield return new WaitForSeconds(1f);
        obj = EnemyManager.instance.Summon2();

        Debug.Log("asdf2");
        obj.transform.position = point1.position;
        obj = EnemyManager.instance.Summon2();
        obj.transform.position = point2.position;
        obj = EnemyManager.instance.Summon2();
        obj.transform.position = point3.position;
        obj = EnemyManager.instance.Summon4();
        obj.transform.position = point4.position;
        yield return new WaitForSeconds(1f);
        obj = EnemyManager.instance.Summon2();
        Debug.Log("asdf2");

        obj.transform.position = point1.position;
        obj = EnemyManager.instance.Summon2();
        obj.transform.position = point2.position;
        obj = EnemyManager.instance.Summon4();
        obj.transform.position = point3.position;
        obj = EnemyManager.instance.Summon2();
        obj.transform.position = point4.position;
        yield return new WaitForSeconds(1f);
        obj = EnemyManager.instance.Summon2();
        Debug.Log("asdf2");

        obj.transform.position = point1.position;
        obj = EnemyManager.instance.Summon4();
        obj.transform.position = point2.position;
        obj = EnemyManager.instance.Summon4();
        obj.transform.position = point3.position;
        obj = EnemyManager.instance.Summon2();
        obj.transform.position = point4.position;
        yield return new WaitForSeconds(1f);
        obj = EnemyManager.instance.Summon2();
        Debug.Log("asdf2");

        obj.transform.position = point1.position;
        obj = EnemyManager.instance.Summon2();
        obj.transform.position = point2.position;
        obj = EnemyManager.instance.Summon2();
        obj.transform.position = point3.position;
        obj = EnemyManager.instance.Summon4();
        obj.transform.position = point4.position;
        yield return new WaitForSeconds(1f);
        obj = EnemyManager.instance.Summon2();
        Debug.Log("asdf2");

        obj.transform.position = point1.position;
        obj = EnemyManager.instance.Summon2();
        obj.transform.position = point2.position;
        obj = EnemyManager.instance.Summon4();
        obj.transform.position = point3.position;
        obj = EnemyManager.instance.Summon4();
        obj.transform.position = point4.position;
        yield return new WaitForSeconds(1f);
        obj = EnemyManager.instance.Summon2();
        Debug.Log("asdf2");

        obj.transform.position = point1.position;
        obj = EnemyManager.instance.Summon4();
        obj.transform.position = point2.position;
        obj = EnemyManager.instance.Summon4();
        obj.transform.position = point3.position;
        obj = EnemyManager.instance.Summon2();
        obj.transform.position = point4.position;
        yield return new WaitForSeconds(1f);
        obj = EnemyManager.instance.Summon2();
        Debug.Log("asdf2");

        obj.transform.position = point1.position;
        obj = EnemyManager.instance.Summon4();
        obj.transform.position = point2.position;
        obj = EnemyManager.instance.Summon2();
        obj.transform.position = point3.position;
        obj = EnemyManager.instance.Summon4();
        obj.transform.position = point4.position;
        yield return new WaitForSeconds(1f);
        Debug.Log("asdf2");

        bosys.Spawn2();
    }

    public IEnumerator Patton3()
    {
        GameObject obj = EnemyManager.instance.Summon3();
        obj.transform.position = point1.position;
        obj = EnemyManager.instance.Summon4();
        obj.transform.position = point2.position;
        obj = EnemyManager.instance.Summon3();
        obj.transform.position = point3.position;
        obj = EnemyManager.instance.Summon4();
        obj.transform.position = point4.position;
        yield return new WaitForSeconds(1f);
        obj = EnemyManager.instance.Summon4();

        obj.transform.position = point1.position;
        obj = EnemyManager.instance.Summon3();
        obj.transform.position = point2.position;
        obj = EnemyManager.instance.Summon4();
        obj.transform.position = point3.position;
        obj = EnemyManager.instance.Summon3();
        obj.transform.position = point4.position;
        yield return new WaitForSeconds(1f);
        bosys.Spawn3();
    }

}
