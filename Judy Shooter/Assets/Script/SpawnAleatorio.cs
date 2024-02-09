using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAleatorio : MonoBehaviour

{
    public GameObject cubePrefab;
    public BoxCollider GridArea;
    public int timeSpawn = 15;

    private void Start()
    {

        InvokeRepeating("Spawn", 0, timeSpawn);
    }

    public void Spawn()
    {
        Bounds area = GridArea.bounds;

        float x = Random.Range(area.min.x, area.max.x);
        float z = Random.Range(area.min.z, area.max.z);


        Vector3 randomSpawnPosition = new Vector3(x, -0.9f, z);
        Instantiate(cubePrefab, randomSpawnPosition, cubePrefab.transform.rotation);
    }



}