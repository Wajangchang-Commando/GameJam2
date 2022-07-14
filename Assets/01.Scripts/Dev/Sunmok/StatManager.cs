using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatManager : MonoBehaviour
{
    public static StatManager Instance;
    public int BowMinAdv;
    public int BowMaxAdv;
    public int KniAdv;
    public int SpeAdv;
    public int GunAdv;
    public float Gundel;
    public int HpAdv;
    private void Awake()
    {
        Instance = this;
    }
}
