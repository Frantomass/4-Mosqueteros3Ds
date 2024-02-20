using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oleadas : MonoBehaviour
{
    public GameObject[] spawnPoints;
    public GameObject enemie;
    public int OleadasCount;
    public int oleadas;
    public bool Spawning;
    private int enemiesSpawned;
    private GameManager gameManager;


    //Start is called before the first frame update
    void Start()
    {
        OleadasCount = 2;
        oleadas = 1;
        Spawning = false;
        enemiesSpawned = 0;
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    //Update is called once per frame
    void Update()
    {
        if (!Spawning && enemiesSpawned == gameManager.defeatedEnemies)
        {
            StartCoroutine(Spawnoleadas(OleadasCount));
        }

    }

    IEnumerator Spawnoleadas(int oleadas)
    {
        Spawning = true;
        //Activar texto de nueva ronda
        yield return new WaitForSeconds(4);
        //Desactivar texto de nueva ronda
        for (int i = 0; i < oleadas; i++)
        {
            SpawnEnemy(oleadas);
            yield return new WaitForSeconds(2);
        }
        oleadas += 1;
        OleadasCount += 2;
        Spawning = false;

        yield break;
    }

    void SpawnEnemy(int oleadas)
    {
        int spawnPos = Random.Range(0, spawnPoints.Length);
        Instantiate(enemie, spawnPoints[spawnPos].transform.position, enemie.transform.rotation);
        enemiesSpawned += 1;
    }
}
