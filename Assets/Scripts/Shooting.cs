using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{

    public Transform firePoint;
    public GameObject bulletPrefab;
    //public Transform Playerpos;
    private float Time;

    private Enemy myObject;
    private Transform playerpos;
    public float bulletForce = 10f;
    // Use this for initialization
    void Start()
    {

        playerpos = myObject.getPlayerpos();
    }

    // Update is called once per frame
    void Update()
    {
        Increment();
        // temp = temp * Time.deltaTime;
        if (Time == 50)
            Shoot();
        if (Time % 215 == 0)
            Shoot();
    }
    void Shoot()
    {
        SoundManager.instance.ShootSound();
        if (Vector2.Distance(transform.position, playerpos.position) < 4f)
        {
            GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
        }
    }
    void Increment()
    {
        Time++;
        // Debug.Log(Time);
    }
}
