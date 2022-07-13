using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHPViewer : MonoBehaviour
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
