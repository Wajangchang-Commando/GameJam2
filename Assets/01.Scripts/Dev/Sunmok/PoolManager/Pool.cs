using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pool : MonoBehaviour
{
    public Stack<Poolable> pool = new Stack<Poolable>();
    Poolable Obj;
    public void Create(Poolable obj)
    {
        Obj = obj;
        for(int i = 0; i< 5; i++)
        {
            Poolable obk = Instantiate(obj);
            obk.name = obj.name;
            pool.Push(obk);
            obk.gameObject.SetActive(false);
            
        }
    }
    public Poolable push(Poolable obj)
    {
        pool.Push(obj);
        obj.gameObject.SetActive(false);
        return obj;
    }
    public Poolable pop()
    {
        Poolable obj;
        if(pool.Count > 0)
        {
            obj = pool.Pop();
            obj.gameObject.SetActive(true);
        }
        else
        {
            obj = Instantiate(Obj);
            obj.name = Obj.name;
        }
        return obj;
    }
}
