using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    public int hits = 2;
    public int points = 5;
    void Start()
    {

    }

    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        hits--;

        //score
        if (hits < -0)
        {
            Destroy(gameObject);
        }
    }
}
