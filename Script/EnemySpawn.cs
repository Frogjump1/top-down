using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField]public static float spawnRadius = 7;
    [SerializeField]private float spawnTime = 1.5f;

    public static int counter = 1;
    [SerializeField] private int limit = 10;

   /* public int Limit 
    { 
        get { return limit; }
        set { limit = value; }
    }*/


    public GameObject[] enemies;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnAnEnemy());
    }
    
    IEnumerator SpawnAnEnemy()
    {
        Vector2 spawnPos = GameObject.FindGameObjectWithTag("Player").transform.position;
        spawnPos += Random.insideUnitCircle.normalized * spawnRadius;

        if(counter <= limit)
        {
            Instantiate(enemies[Random.Range(0, enemies.Length)], spawnPos, Quaternion.identity);
            counter++;
        }

        yield return new WaitForSeconds(spawnTime);

        StartCoroutine(SpawnAnEnemy());

    }
}
