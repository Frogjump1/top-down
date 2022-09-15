using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootPoint : MonoBehaviour
{
    public Camera cam;
    Vector2 mousePos;
    public Rigidbody2D Rb;
    

    // Update is called once per frame
    void Update()
    {
        
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
    }
    void FixedUpdate()
    {
        

        Vector3 lookdir = mousePos - Rb.position;
        float angel = Mathf.Atan2(lookdir.y, lookdir.x) * Mathf.Rad2Deg - 90f;
        Rb.rotation = angel;
    }
}
