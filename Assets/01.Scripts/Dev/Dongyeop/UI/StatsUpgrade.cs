using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatsUpgrade : MonoBehaviour //스텟 업그래이드를 할 수 있습니다.
{
    [SerializeField] private GameObject KnifeDamageUpBTN;
    [SerializeField] private GameObject KnifeAdvantageUpBTN;
    [SerializeField] private GameObject BowMinPowUpBTN;
    [SerializeField] private GameObject BowMaxPowUpBTN;
    [SerializeField] private GameObject GunAdvantageUpBTN;
    [SerializeField] private GameObject GundamageUpBTN;
    [SerializeField] private GameObject PlayerHPnowHPUpBTN;

    [SerializeField] private Text _txt;


    public float statsPoint = 0;


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

        /*if (statsPoint < 1)
        {
            KnifeDamageUpBTN.SetActive(false);
            KnifeAdvantageUpBTN.SetActive(false);
            BowMinPowUpBTN.SetActive(false);
            BowMaxPowUpBTN.SetActive(false);
            GunAdvantageUpBTN.SetActive(false);
            GundamageUpBTN.SetActive(false);
            PlayerHPnowHPUpBTN.SetActive(false);
        }
        else
        {
            KnifeDamageUpBTN.SetActive(true);
            KnifeAdvantageUpBTN.SetActive(true);
            BowMinPowUpBTN.SetActive(true);
            BowMaxPowUpBTN.SetActive(true);
            GunAdvantageUpBTN.SetActive(true);
            GundamageUpBTN.SetActive(true);
            PlayerHPnowHPUpBTN.SetActive(true);
        }*/

        _txt.text = "남은 스텟 수 : " + statsPoint;
    }


    public void KnifeDamageUp()
    {
        if (StatManager.Instance.KniAdv <= 7 && statsPoint > 0.9f)
        {
            StatManager.Instance.KniAdv++;
            statsPoint--;
        }
    }

    public void KnifeAdvantageUp()
    {
        if (StatManager.Instance.SpeAdv <= 4 && statsPoint > 0.9f)
        {
            StatManager.Instance.SpeAdv++;
            statsPoint--;
        }
    }

    public void BowMinPowUp()
    {
        if(StatManager.Instance.BowMinAdv <= 3 && statsPoint > 0.9f)
        {
            StatManager.Instance.BowMinAdv++;
            statsPoint--;

        }
    }

    public void BowMaxPowUp()
    {
        if (StatManager.Instance.BowMaxAdv <= 3 && statsPoint > 0.9f)
        {
            StatManager.Instance.BowMaxAdv++;
            statsPoint--;

        }
    }

    public void GunAdvantageUp()
    {
        if (StatManager.Instance.Gundel <= 2 && statsPoint > 0.9f)
        {
            StatManager.Instance.Gundel +=0.2f;
            statsPoint--;

        }
    }

    public void GundamageUp()
    {
        if (StatManager.Instance.GunAdv <= 2 && statsPoint > 0.9f)
        {
            StatManager.Instance.GunAdv++;
            statsPoint--;
        }
    }

    public void PlayerHPnowHPUp()
    {
        if (StatManager.Instance.HpAdv <= 4 && statsPoint > 0.9f)
        {
            StatManager.Instance.HpAdv++;
            statsPoint--;
        }
    }
}
