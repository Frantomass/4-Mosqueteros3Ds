using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public float spawntime = 5f;
    public GameObject objetoAInstanciar;
    public int maxEnemies = 3;
    private Transform playerposition;

    private void Start()
    {
        playerposition = GameObject.FindGameObjectWithTag("Player").transform;
        InvokeRepeating("CheckAndSpawnEnemies", 1f, spawntime);
    }
    public void CheckAndSpawnEnemies()
    {
        int currentEnemies = GameObject.FindGameObjectsWithTag("minion").Length;

        if (currentEnemies < maxEnemies)
        {
            SpawnObject();
        }
    }

    void SpawnObject()
    {
        Instantiate(objetoAInstanciar, transform.position, Quaternion.identity);
    }

    public void EnemyDestroyed()
    {
        Invoke("CheckAndSpawnEnemies", spawntime);
    }
}