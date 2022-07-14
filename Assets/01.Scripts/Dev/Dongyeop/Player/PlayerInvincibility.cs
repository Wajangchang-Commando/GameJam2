using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInvincibility : MonoBehaviour //플레이어가 피격시 깜박거리는거
{
    [SerializeField] private BoxCollider2D _coll; //플레이어를 끌어와주세요. 

    public IEnumerator Invincibility()
    {
        _coll.enabled = false;

        GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0);
        yield return new WaitForSeconds(0.05f);
        GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
        yield return new WaitForSeconds(0.05f);
        GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0);
        yield return new WaitForSeconds(0.05f);
        GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
        yield return new WaitForSeconds(0.05f);
        GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0);
        yield return new WaitForSeconds(0.05f);
        GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);

        _coll.enabled = true;
    }
}
