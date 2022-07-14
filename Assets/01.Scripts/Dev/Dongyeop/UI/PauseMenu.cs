using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject _pauseMenu;

    private StatsPanel _statsPanel;

    public bool pauseState = false;

    private void Awake()
    {
        _statsPanel = GetComponent<StatsPanel>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && _statsPanel.statsState == false)
        {
            if (pauseState == false)
                PauseOn();
            else if (pauseState == true)
                PauseOff();
        }
    }

    #region PauseMenu On/Off
    public void PauseOn()
    {
        _pauseMenu.SetActive(true);
        pauseState = true;
        Time.timeScale = 0;
    }
    public void PauseOff()
    {
        Time.timeScale = 1;
        _pauseMenu.SetActive(false);
        pauseState = false;
    }
    #endregion
}
