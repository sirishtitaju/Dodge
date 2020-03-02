using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{

    public GameObject enemy;
    public float timeBtwEnemySpawn;
    public float startTimeBtwEnemySpawn;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        // float RandomXpos = Random.Range(5f, -5f);
        // pos.x = RandomXpos;
        // pos.y = RandomXpos;
        if (timeBtwEnemySpawn <= 0)
        {
            Instantiate(enemy, pos, Quaternion.identity);
            timeBtwEnemySpawn = startTimeBtwEnemySpawn;
        }
        else
        {
            timeBtwEnemySpawn -= Time.deltaTime;
        }

    }
}
