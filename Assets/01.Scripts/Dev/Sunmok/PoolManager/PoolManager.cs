using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager : MonoBehaviour
{
    Dictionary<string, Pool> pools = new Dictionary<string, Pool>();
    //poolable들로 추가할 것
    public Poolable obj1;
    public Poolable obj2;
    public Poolable obj3;
    public Poolable obj4;
    public Poolable obj5;
    public Poolable obj6;
    public Poolable obj7;
    public Poolable obj8;
    public Poolable obj9;
    public Poolable obj10;
    public Poolable obj11;
    public static PoolManager Instance;

    private void Awake()
    {
        Instance = this;
        make(obj1);
        make(obj2);
        make(obj3);
        make(obj4);
        make(obj5);
        make(obj6);
        make(obj7);
        make(obj8);
        make(obj9);
        make(obj10);
        make(obj11);
    }
    public void make(Poolable pol)
    {
        Pool pool = new Pool();
        pool.Create(pol);
        pools.Add(pol.name, pool);
    }
    public Poolable Summon(string name)
    {
        Poolable obj = pools[name].pop();
        return obj;
    }
    public void Returner(Poolable obj)
    {
        pools[obj.name].push(obj);
    }
}
