using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveController : MonoBehaviour
{

    public float WaveTimeCounter;

    public GameObject Spawner1, Spawner2, Spawner3, Spawner4, Spawner5, Spawner6;
    // Use this for initialization
    void Start()
    {
        print("Wave 1");
    }

    // Update is called once per frame
    void Update()
    {
        WaveTimeCounter += Time.deltaTime;
        //print("WaveTime " + WaveTimeCounter);
        if (WaveTimeCounter >= 10 && WaveTimeCounter < 15)
        {
            print("Wave 2");
            Spawner1.SetActive(true);
        }

        if (WaveTimeCounter >= 30 && WaveTimeCounter < 50)
        {
            print("Wave 3");
            Spawner2.SetActive(true);
        }

        if (WaveTimeCounter >= 53 && WaveTimeCounter < 80)
        {
            print("Wave 4");
            Spawner3.SetActive(true);
        }
        if (WaveTimeCounter >= 83 && WaveTimeCounter < 110)
        {
            print("Wave 5");
            Spawner4.SetActive(true);
        }
        if (WaveTimeCounter >= 112 && WaveTimeCounter < 200)
        {
            print("Wave 6");
            Spawner5.SetActive(true);
        }
        if (WaveTimeCounter > 200)
        {
            print("Wave 7");
            Spawner6.SetActive(true);
        }

    }
}
