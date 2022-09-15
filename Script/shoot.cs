using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public Transform firePoit;
    public GameObject shoterfireball;
    public GameObject hiteffect;
    public float cooldown = 1f;
    public float lastTime;
    public int playerHP = 3;

    public float bulletForce = 25f;

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && (Time.time - lastTime) > cooldown)
        {
            lastTime = Time.time;
            Shoot();
        }
       
    }

    void Shoot()
    {
        GameObject fireball = Instantiate(shoterfireball, firePoit.position, firePoit.rotation);
        Rigidbody2D Rb = fireball.GetComponent<Rigidbody2D>();
        Rb.AddForce(firePoit.up * bulletForce, ForceMode2D.Impulse);
        Destroy(fireball, 0.4f);
    }

   
}
