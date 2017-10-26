using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMinotaur : MonoBehaviour
{

    public GameObject minotaur;
    public GameObject enemySpawn;
    public int enemiesCreated;
    public float timer;

	void Start ()
    {
        timer = 0;
	}
	
	void Update ()
    {
        timer = Time.time;
        SpawnEnemy();
	}

    void SpawnEnemy()
    {
        if (timer >= 30.0f && timer <= 31.0f && enemiesCreated != 1)
        {
            Instantiate(minotaur, enemySpawn.transform.position, enemySpawn.transform.rotation);
            enemiesCreated++;
        }
    }
}
