using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AlphaBtn : MonoBehaviour //��ư�� ������ ��ư�� ��翡 �°� ���� �� �ֽ��ϴ�
{
    private float AlphaThreshold = 0.1f;

    private void Start()
    {
        this.GetComponent<Image>().alphaHitTestMinimumThreshold = AlphaThreshold;
    }
}
