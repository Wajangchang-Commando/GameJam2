using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatsUpgrade : MonoBehaviour
{
    private Knife _knife;
    private PlayerMove _playerMove;
    private Bow _bow;
    private Gun _gun;
    private Bullet _bullet;
    private PlayerHP _playerHP;

    private void Awake()
    {
        _knife = GetComponent<Knife>();
        _playerMove = GetComponent<PlayerMove>();
        _bow = GetComponent<Bow>();
        _gun = GetComponent<Gun>();
        _bullet = GetComponent<Bullet>();
        _playerHP = GetComponent<PlayerHP>();
    }


    public void KnifeDamageUp()
    {
        _knife.Damage++;
    }

    public void KnifeAdvantageUp()
    {
        _playerMove.Advantage++;
    }

    public void BowMinPowUp()
    {
        _bow.MinPow++;
    }

    public void BowMaxPowUp()
    {
        _bow.MaxPow++;
    }

    public void GunAdvantageUp()
    {
        _gun.Advantage--;
    }

    public void GundamageUp()
    {
        _bullet.damage++;
    }

    public void PlayerHPnowHPUp()
    {
        _playerHP.nowHP++;
    }
}
