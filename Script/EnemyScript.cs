using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public Transform[] Waypoints;
    [SerializeField] public float speed = 2;
    [SerializeField] public int enemyHP = 2;
    public int CurrentPoint = 0;
    

    void Update()
    {
        if (enemyHP <= 0)
        {
            Die(this.gameObject);
        }
        if (transform.position.y != Waypoints[CurrentPoint].transform.position.y)
        {
            transform.position = Vector3.MoveTowards(transform.position, Waypoints[CurrentPoint].transform.position, speed * Time.deltaTime);
        }

        if (transform.position.y == Waypoints[CurrentPoint].transform.position.y)
        {
            CurrentPoint += 1;
        }
        if (CurrentPoint >= Waypoints.Length)
        {
            CurrentPoint = 0;
        }
    }
    void OnCollisionEnter2D(Collision2D collision) { 
        if(collision.gameObject.tag == "Projectiles")
        {
            enemyHP--;
        }     
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="entity">Object to be destroyed</param>
    static void Die(GameObject entity)
    {
        Destroy(entity); // destroy object
        EnemySpawn.counter--; // decrease counter
    }
}
