using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatsUpgrade : MonoBehaviour
{
    private Knife _knife;
    private PlayerMove _playerMove;
    private Bow _bow;
    private Gun _gun;
    private PlayerHP _playerHP;

    private int _knifeDam = 0;
    public int _knifeADV = 0;
    private int _bowMin = 0;
    private int _bowMax = 0;
    private int _gunADV = 0;
    private int _gunDam = 0;

    private void Awake()
    {
        _knife = GameObject.Find("Knife").GetComponent<Knife>();
        _playerMove = GameObject.Find("Player").GetComponent<PlayerMove>();
        _bow = GameObject.Find("Bow").GetComponent<Bow>();
        _gun = GameObject.Find("Gun").GetComponent<Gun>();
        _playerHP = GameObject.Find("Player").GetComponent<PlayerHP>();
    }


    public void KnifeDamageUp()
    {
        if (_knifeDam <= 7)
        {
            _knife.Damage++;
            _knifeDam++;
        }
    }

    public void KnifeAdvantageUp()
    {
        if (_knifeADV <= 4)
        {
            _playerMove.Advantage++;
            _knifeADV++;
        }
    }

    public void BowMinPowUp()
    {
        if(_bowMin <= 3)
        {
            _bow.MinPow++;
            _bowMin++;
        }
    }

    public void BowMaxPowUp()
    {
        if ( _bowMax <= 3)
        {
            _bow.MaxPow++;
            _bowMax++;
        }
    }

    public void GunAdvantageUp()
    {
        if (_gunADV <= 3)
        {
            _gun.Advantage--;
            _gunADV++;
        }
    }

    public void GundamageUp()
    {
        if (_gunDam <= 2)
        {
            _gun.Damage++;
            _gunDam++;
        }
    }

    public void PlayerHPnowHPUp()
    {
        _playerHP.nowHP++;
    }
}
