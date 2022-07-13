using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Bow : MonoBehaviour
{
    [SerializeField] float MaxPow;
    [SerializeField] float NPow;
    [SerializeField] float CPow;
    [SerializeField] Animator anim;
    private void Update()
    {

        if (Input.GetMouseButton(0))
        {
            NPow += CPow * Time.deltaTime;
            NPow = Mathf.Clamp(NPow, 0, MaxPow);
            anim.SetBool("Charging", true);
        }
    }
}
