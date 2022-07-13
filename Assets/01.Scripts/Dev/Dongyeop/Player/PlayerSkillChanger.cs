using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSkillChanger : MonoBehaviour // Q, E를 누르면 사용 가능 스킬이 바뀝니다.
{
    #region 스킬 표시될 것들 SerializeField로 받아온것들
    [Header ("Player Skill Now")]
    [SerializeField] private GameObject _nowGun;
    [SerializeField] private GameObject _nowBow;
    [SerializeField] private GameObject _nowKnife;
    [Header ("Player Skill Q")]
    [SerializeField] private GameObject _qGun;
    [SerializeField] private GameObject _qBow;
    [SerializeField] private GameObject _qKnife;
    [Header ("Player Skill E")]
    [SerializeField] private GameObject _eGun;
    [SerializeField] private GameObject _eBow;
    [SerializeField] private GameObject _eKnife;
    #endregion

    private int _nowNum = 1;
    private int qNum = 2;
    private int _eNum = 3;
    private int _reset = 0;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
            InputQ();
        if (Input.GetKeyDown(KeyCode.E))
            InputE();
    }

    #region 하드코딩.
    private void InputQ()
    {
        switch (_nowNum)
        {
            case 1:
                if (qNum == 2)
                {
                    Helpme(_nowGun, _nowBow, _qBow, _qGun);
                    _reset = _nowNum;
                    _nowNum = qNum;
                    qNum = _reset;
                    _reset = 0;
                }
                else if (qNum == 3)
                {
                    Helpme(_nowGun, _nowKnife, _qKnife, _qGun);
                    _reset = _nowNum;
                    _nowNum = qNum;
                    qNum = _reset;
                    _reset = 0;
                }
                break;
            case 2:
                if(qNum == 1)
                {
                    Helpme(_nowBow, _nowGun, _qGun, _qBow);
                    _reset = _nowNum;
                    _nowNum = qNum;
                    qNum = _reset;
                    _reset = 0;
                }
                else if (qNum == 3)
                {
                    Helpme(_nowBow, _nowKnife, _qKnife, _qBow);
                    _reset = _nowNum;
                    _nowNum = qNum;
                    qNum = _reset;
                    _reset = 0;
                }
                break;
            case 3:
                if (qNum == 1)
                {
                    Helpme(_nowKnife, _nowGun, _qGun, _qKnife);
                    _reset = _nowNum;
                    _nowNum = qNum;
                    qNum = _reset;
                    _reset = 0;
                }
                else if (qNum == 2)
                {
                    Helpme(_nowKnife, _nowBow, _qBow, _qKnife);
                    _reset = _nowNum;
                    _nowNum = qNum;
                    qNum = _reset;
                    _reset = 0;
                }
                break;
            default:
                break;
        }
    }

    private void InputE()
    {
        switch (_nowNum)
        {
            case 1:
                if (_eNum == 2)
                {
                    Helpme(_nowGun, _nowBow, _eBow, _eGun);
                    _reset = _nowNum;
                    _nowNum = _eNum;
                    _eNum = _reset;
                    _reset = 0;
                }
                else if (_eNum == 3)
                {
                    Helpme(_nowGun, _nowKnife, _eKnife, _eGun);
                    _reset = _nowNum;
                    _nowNum = _eNum;
                    _eNum = _reset;
                    _reset = 0;
                }
                break;
            case 2:
                if (_eNum == 1)
                {
                    Helpme(_nowBow, _nowGun, _eGun, _eBow);
                    _reset = _nowNum;
                    _nowNum = _eNum;
                    _eNum = _reset;
                    _reset = 0;
                }
                else if (_eNum == 3)
                {
                    Helpme(_nowBow, _nowKnife, _eKnife, _eBow);
                    _reset = _nowNum;
                    _nowNum = _eNum;
                    _eNum = _reset;
                    _reset = 0;
                }
                break;
            case 3:
                if (_eNum == 1)
                {
                    Helpme(_nowKnife, _nowGun, _eGun, _eKnife);
                    _reset = _nowNum;
                    _nowNum = _eNum;
                    _eNum = _reset;
                    _reset = 0;
                }
                else if (_eNum == 2)
                {
                    Helpme(_nowKnife, _nowBow, _eBow, _eKnife);
                    _reset = _nowNum;
                    _nowNum = _eNum;
                    _eNum = _reset;
                    _reset = 0;
                }
                break;
            default:
                break;
        }
    }
    #endregion

    private void Helpme(GameObject oneone, GameObject onetwo, GameObject twoone, GameObject twotwo)
    {
        oneone.SetActive (false);
        onetwo.SetActive (true);
        twoone.SetActive (false);
        twotwo.SetActive(true);
    }
}
