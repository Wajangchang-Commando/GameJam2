using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatsUpgrade : MonoBehaviour //스텟 업그래이드를 할 수 있습니다.
{
    [SerializeField] private GameObject KnifeDamageUpBTN;
    [SerializeField] private GameObject KnifeAdvantageUpBTN;
    [SerializeField] private GameObject BowMinPowUpBTN;
    [SerializeField] private GameObject BowMaxPowUpBTN;
    [SerializeField] private GameObject GunAdvantageUpBTN;
    [SerializeField] private GameObject GundamageUpBTN;
    [SerializeField] private GameObject PlayerHPnowHPUpBTN;



    private void Update()
    {
        if (StatManager.Instance.KniAdv >= 7)
            Destroy(KnifeDamageUpBTN);
        if (StatManager.Instance.SpeAdv >= 4)
            Destroy(KnifeAdvantageUpBTN);
        if (StatManager.Instance.BowMinAdv >= 3)
            Destroy(BowMinPowUpBTN);
        if (StatManager.Instance.BowMaxAdv >= 3)
            Destroy(BowMaxPowUpBTN);
        if (StatManager.Instance.Gundel >= 2)
            Destroy(GunAdvantageUpBTN);
        if (StatManager.Instance.GunAdv >= 2)
            Destroy(GundamageUpBTN);
        if (StatManager.Instance.HpAdv>= 4)
            Destroy(PlayerHPnowHPUpBTN);
    }


    public void KnifeDamageUp()
    {
        if (StatManager.Instance.KniAdv <= 7)
        {
            StatManager.Instance.KniAdv++;
        }
    }

    public void KnifeAdvantageUp()
    {
        if (StatManager.Instance.SpeAdv <= 4)
        {
            StatManager.Instance.SpeAdv++;
        }
    }

    public void BowMinPowUp()
    {
        if(StatManager.Instance.BowMinAdv <= 3)
        {
            StatManager.Instance.BowMinAdv++;

        }
    }

    public void BowMaxPowUp()
    {
        if (StatManager.Instance.BowMaxAdv <= 3)
        {
            StatManager.Instance.BowMaxAdv++;

        }
    }

    public void GunAdvantageUp()
    {
        if (StatManager.Instance.Gundel <= 2)
        {
            StatManager.Instance.Gundel +=0.2f;

        }
    }

    public void GundamageUp()
    {
        if (StatManager.Instance.GunAdv <= 2)
        {
            StatManager.Instance.GunAdv++;
        }
    }

    public void PlayerHPnowHPUp()
    {
        if (StatManager.Instance.HpAdv <= 4)
        {
            StatManager.Instance.HpAdv++;
        }
    }
}
