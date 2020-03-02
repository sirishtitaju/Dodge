using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public float speed;
    public float stoppingDistance;
    public static Transform player;
    // Use this for initialization
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 difference = player.position - transform.position;
        float rotationZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg - 90f;
        transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotationZ);

        if (Vector2.Distance(transform.position, player.position) > stoppingDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);

        }
        else if (Vector2.Distance(transform.position, player.position) < stoppingDistance - 0.5f)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, -1 * speed * Time.deltaTime); ;
        }

    }
    public Transform getPlayerpos()
    {
        player = this.transform;
        return player;
    }
}
