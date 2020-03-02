using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadiusScoreScript : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Player" && other.tag == "Yellow")
            Debug.Log("Yellow Score for Player");
    }
}
