using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossHPViewer : MonoBehaviour //silde�� �� ģ���Դϴ�. ���� ���� ����� "_backGround.color = Color.clear;" "_backGround.color = Color.white;" �̰� ���� �����ּ���.
{
    [Header ("���� ������")]
    [SerializeField] private BossHP _firstbossHP;
    [SerializeField] private BossHP _secondbossHP;
    [SerializeField] private BossHP _thirdbossHP;

    [Header ("Slider BackGround")]
    [SerializeField] private Image _backGround; //BossSilder �ȿ� ����ִ� "BackGround"�� �־��ּ���

    private Slider _sliderHP;

    private void Awake()
    {
        _sliderHP = GetComponent<Slider>();
    }

    private void Start()
    {
        _backGround.color = Color.clear;
    }


    #region ù���� ���� HP
    public IEnumerator FirstBossSpawn() //ù���� �����Ǹ� ��������ּ���
    {
        _backGround.color = Color.white;
        while (true)
        {
            _sliderHP.value = _firstbossHP.CurrentHP / _firstbossHP.MaxHP;
            yield return null;
        }
    }
    public void FirstBossDie() //ù��° ���� �׾����� ������� �ּ���.
    {
        StopCoroutine(FirstBossSpawn());
        _backGround.color = Color.clear;
    }
    #endregion

    #region �ι��� ���� ���� HP
    public IEnumerator SecondBossSpawn() //�ι��� ���� �����Ǹ� ��������ּ���
    {
        _backGround.color = Color.white;
        while (true)
        {
            _sliderHP.value = _secondbossHP.CurrentHP / _secondbossHP.MaxHP;
            yield return null;
        }
    }
    public void SecondBossDie() //�ι��� ���� ������ ��������ּ���
    {
        StopCoroutine(SecondBossSpawn());
        _backGround.color = Color.clear;
    }
    #endregion

    #region ������ ���� ���� HP
    public IEnumerator ThirdBossSpawn() //�ι��� ���� �����Ǹ� ��������ּ���
    {
        _backGround.color = Color.white;
        while (true)
        {
            _sliderHP.value = _thirdbossHP.CurrentHP / _thirdbossHP.MaxHP;
            yield return null;
        }
    }
    public void ThirdBossDie() //������ ���� ������ ���� �����ּ���
    {
        StopCoroutine(ThirdBossSpawn());
        _backGround.color = Color.clear;
    }
    #endregion
}
