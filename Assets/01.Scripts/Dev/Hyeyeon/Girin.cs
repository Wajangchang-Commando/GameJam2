using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Girin : MonoBehaviour
{
    [SerializeField] private Transform _player;
    [SerializeField] private GameObject _bullet;

    [SerializeField] private float timer;
    [SerializeField] private float waitingTime;

    private void Start()
    {
        timer = 0.0f;
        waitingTime = 2f;
    }

    private void Update()
    {
        timer += Time.deltaTime;

        if(timer > waitingTime)
        {
            timer = 0;
            shot();
        }
    }

    public void shot()
    {
        var bl = new List<Transform>();

        for (int i = 0; i < 360; i += 13)
        {
            var temp = Instantiate(_bullet);

            Destroy(temp, 5f);

            Vector2 positionsBullet = new Vector2(this.gameObject.transform.position.x, this.gameObject.transform.position.y);

            bl.Add(temp.transform);

            temp.transform.rotation = Quaternion.Euler(0, 0, i);
        }
        StartCoroutine(BulletToTarget(bl));
    }

    IEnumerator BulletToTarget(List<Transform> bl)
    {
        yield return new WaitForSeconds(0.5f);

        for (int i = 0; i < bl.Count; i++)
        {
            var target_dir = _player.transform.position - bl[i].position;

            var angle = Mathf.Atan2(target_dir.y, target_dir.x) * Mathf.Rad2Deg;

            bl[i].rotation = Quaternion.Euler(0, 0, angle);
        }
        bl.Clear();
    }
}
