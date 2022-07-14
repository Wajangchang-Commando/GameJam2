using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AlphaBtn : MonoBehaviour //버튼을 누를때 버튼의 모양에 맞게 누를 수 있습니다. 웬만하면 사용 안 하실거니 신경 안 쓰셔도 됩니다.
{
    private float AlphaThreshold = 0.1f;

    private void Start()
    {
        this.GetComponent<Image>().alphaHitTestMinimumThreshold = AlphaThreshold;
    }
}
