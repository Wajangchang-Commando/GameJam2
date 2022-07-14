using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHPViewer : MonoBehaviour // 플레이어HP를 표현할 slider에 들어갈 스크립트입니다. 
{
    [SerializeField] private PlayerHP _playerHP;
    Slider sliderHP;

    private void Start()
    {
        sliderHP = GetComponent<Slider>();
    }

    private void Update()
    {

        sliderHP.value = _playerHP.CurrentHP / _playerHP.MaxHP;
    }
}
