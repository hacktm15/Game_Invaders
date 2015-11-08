﻿using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
    public GameObject hazard;
    public Vector3 spawnValues;
    public int hazardCount;
    void Start()
    {
        SpawnWaves();
    }
    void SpawnWaves()
    {
        for (int i = 0; i < hazardCount; i++)
        {
            Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
            Quaternion spawnRotation = Quaternion.identity;
            Instantiate(hazard, spawnPosition, spawnRotation);
        }
        }
	
}
