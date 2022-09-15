using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class greenslime : MonoBehaviour
{
    public float ms;
    public Rigidbody2D Rb;
    private Transform target;
    public float jarak;
    // Start is called before the first frame update
    void Start()
    {
        Rb = this.GetComponent<Rigidbody2D>();
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
       if(Vector2.Distance(transform.position, target.position) > jarak)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, ms * Time.deltaTime);
        }
    }
 
}
