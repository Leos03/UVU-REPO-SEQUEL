using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawnPickup : MonoBehaviour
{
    public GameObject[] SpawnRandomPickup;
    private float spawnRangeX = 25f;

    private float spawnPosZ = 25f;

    private float startDelay = 5f;
    private float spawnInterval = 10f;

    void Start()
    {
        InvokeRepeating("SpawnRandomPickup", startDelay, spawnInterval);
    }

    void SpawnRandomUFO()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        int ufoIndex = Random.Range(0, ufoPrefabs.Length);
        Instantiate(ufoPrefabs[ufoIndex], spawnPos, ufoPrefabs[ufoIndex].transform.rotation);
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Debug.Log("Increased *insert powerup stuff");
    }