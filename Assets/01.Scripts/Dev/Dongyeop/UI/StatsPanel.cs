using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatsPanel : MonoBehaviour // TAB�� ������ STATS �ǳ��� ���Ϳ� 
{
    [SerializeField] private GameObject statsMenu;

    private PauseMenu _pauseMenu;

    public bool statsState = false;

    private void Awake()
    {
        _pauseMenu = GetComponent<PauseMenu>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab) && _pauseMenu.pauseState == false)
        {
            if (statsState == false)
                StatsOn();
            else if (statsState == true)
                StatsOff();
        }
    }

    #region StatsMenu On/Off
    public void StatsOn()
    {
        statsMenu.SetActive(true);
        statsState = true;
        Time.timeScale = 0;
    }
    public void StatsOff()
    {
        Time.timeScale = 1;
        statsMenu.SetActive(false);
        statsState = false;
    }
    #endregion
}
