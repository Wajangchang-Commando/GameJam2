using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AlphaBtn : MonoBehaviour //��ư�� ������ ��ư�� ��翡 �°� ���� �� �ֽ��ϴ�. �����ϸ� ��� �� �ϽǰŴ� �Ű� �� ���ŵ� �˴ϴ�.
{
    private float AlphaThreshold = 0.1f;

    private void Start()
    {
        this.GetComponent<Image>().alphaHitTestMinimumThreshold = AlphaThreshold;
    }
}
