using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour {

    public GameObject pooledBall; //the prefab of the object in the object pool

    private void Start()
    {
        InvokeRepeating("SpawnBall", 0f, 0.5f);
    }

    void SpawnBall()
    {
        Instantiate(pooledBall);
    }
}
