using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class minion : MonoBehaviour
{
    public float velocidad = 3f;
    private Transform player;
    private Spawn spawner;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        spawner = GameObject.FindObjectOfType<Spawn>();
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, player.position, velocidad * Time.deltaTime);
    }

    private void OnDestroy()
    {
        if (spawner != null)
        {
            spawner.EnemyDestroyed();
        }
    }
}
