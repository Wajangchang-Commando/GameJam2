using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Bow : MonoBehaviour
{
    [SerializeField] float MaxPow;
    [SerializeField] float NPow;
    [SerializeField] float CPow;
    [SerializeField] Animator anim;
    [SerializeField] Vector3 point;
    [SerializeField] private GameObject Arrow;
    [SerializeField] private SpriteRenderer SPR;
    [SerializeField] private float angle;
    [SerializeField] private GameObject nowA;
    private void Update()
    {
        Bowturn();
        Shoot();
    }
    private void Shoot()
    {
        if (Input.GetMouseButtonDown(0))
        {
            nowA= Instantiate(Arrow);
        }
        if (Input.GetMouseButton(0))
        {
            nowA.transform.position = transform.position;
            nowA.transform.rotation = transform.rotation;
            NPow += CPow * Time.deltaTime;
            NPow = Mathf.Clamp(NPow, 5, MaxPow);
            anim.SetBool("Charging", true);
        }
        if (Input.GetMouseButtonUp(0))
        {
            nowA.GetComponent<Rigidbody2D>().AddForce((point-transform.position).normalized * NPow, ForceMode2D.Impulse);
            anim.SetBool("Charging", false);
            NPow = 0;
        }
    }
    void Bowturn()
    {
        point = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z + 10));

        Vector3 Rot = point - transform.position;

        Rot.Normalize();
        angle = Mathf.Atan2(Rot.y, Rot.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, angle);

    }
}
