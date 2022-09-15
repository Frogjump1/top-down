using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyspwan : MonoBehaviour
{
    [SerializeField]
    private GameObject greenSlime;

    [SerializeField]
    public float greenSlimeInterval;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spwanEnemy(greenSlimeInterval, greenSlime));
    }

    private IEnumerator spwanEnemy(float interval , GameObject enemy)
    {
        yield return new WaitForSeconds(interval);
        GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(-20f, 20f), Random.Range(-25f, 25f), 0), Quaternion.identity);
        StartCoroutine(spwanEnemy(interval, enemy));
    }    
}
