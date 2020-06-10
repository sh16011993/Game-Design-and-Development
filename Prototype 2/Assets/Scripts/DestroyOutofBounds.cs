﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutofBounds : MonoBehaviour
{
    float topBound = 30;
    float lowerBound = -10;

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > topBound){
            Destroy(gameObject);
        }
        else if(transform.position.z < lowerBound){
            Destroy(gameObject);
            Debug.Log("Game Over!");
        }
    }
}
