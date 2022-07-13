using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour //���� �� �Ѿ�� �͵�
{
    [SerializeField] private int _sceneChangeNum1;
    [SerializeField] private int _sceneChangeNum2;

    public void SceneChange1()
    {
        SceneManager.LoadScene(_sceneChangeNum1);
    }
    public void SceneChange2()
    {
        SceneManager.LoadScene(_sceneChangeNum2);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
 