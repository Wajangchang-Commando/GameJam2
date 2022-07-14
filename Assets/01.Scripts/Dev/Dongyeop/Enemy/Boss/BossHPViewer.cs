using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossHPViewer : MonoBehaviour //silde에 들어갈 친구입니다. 만약 문제 생기면 "_backGround.color = Color.clear;" "_backGround.color = Color.white;" 이거 먼저 없애주세요.
{
    [Header ("각종 보스들")]
    [SerializeField] private BossHP _firstbossHP;
    [SerializeField] private BossHP _secondbossHP;
    [SerializeField] private BossHP _thirdbossHP;

    [Header ("Slider BackGround")]
    [SerializeField] private Image _backGround; //BossSilder 안에 들어있는 "BackGround"를 넣어주세요

    private Slider _sliderHP;

    private void Awake()
    {
        _sliderHP = GetComponent<Slider>();
    }

    private void Start()
    {
        _backGround.color = Color.clear;
    }


    #region 첫보스 관련 HP
    public IEnumerator FirstBossSpawn() //첫보스 생성되면 실행시켜주세요
    {
        _backGround.color = Color.white;
        while (true)
        {
            _sliderHP.value = _firstbossHP.CurrentHP / _firstbossHP.MaxHP;
            yield return null;
        }
    }
    public void FirstBossDie() //첫번째 보스 죽었을떄 실행시켜 주세요.
    {
        StopCoroutine(FirstBossSpawn());
        _backGround.color = Color.clear;
    }
    #endregion

    #region 두번쨰 보스 관련 HP
    public IEnumerator SecondBossSpawn() //두번쨰 보스 생성되면 실행시켜주세요
    {
        _backGround.color = Color.white;
        while (true)
        {
            _sliderHP.value = _secondbossHP.CurrentHP / _secondbossHP.MaxHP;
            yield return null;
        }
    }
    public void SecondBossDie() //두번쨰 보스 죽으면 실행시켜주세요
    {
        StopCoroutine(SecondBossSpawn());
        _backGround.color = Color.clear;
    }
    #endregion

    #region 세번쨰 보스 관련 HP
    public IEnumerator ThirdBossSpawn() //두번쨰 보스 생성되면 실행시켜주세요
    {
        _backGround.color = Color.white;
        while (true)
        {
            _sliderHP.value = _thirdbossHP.CurrentHP / _thirdbossHP.MaxHP;
            yield return null;
        }
    }
    public void ThirdBossDie() //세번쨰 보스 죽으면 실행 시켜주세요
    {
        StopCoroutine(ThirdBossSpawn());
        _backGround.color = Color.clear;
    }
    #endregion
}
