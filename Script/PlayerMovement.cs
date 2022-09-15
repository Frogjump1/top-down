using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody2D Rb;
    public Camera Cam;
    public GameObject canvasUI;
    public int playerHP = 3;
    public float ms;
    Vector3 run;
    public Animator anime;



    void Update()
    {
        run.x = Input.GetAxisRaw("Horizontal");
        run.y = Input.GetAxisRaw("Vertical");
        transform.position += run * ms * Time.deltaTime;

        if(run == Vector3.zero)
        {
            anime.SetBool("walk", false);
            anime.SetBool("walkkanan", false);
            anime.SetBool("depan", false);
            anime.SetBool("belakang", false);

        }else if(run == Vector3.left)
        {
            anime.SetBool("walk", true);
        }
        else if(run == Vector3.right)
        {
            anime.SetBool("walkkanan", true);
        }
        else if(run == Vector3.up)
        {
            anime.SetBool("belakang", true);
        }
        else if(run == Vector3.down)
        {
            anime.SetBool("depan", true);
        }

        

    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            playerHP--;
        }
    }

    
    void PlayerDied()
    {
        if (playerHP == 0)
        {
            Destroy(gameObject);
            canvasUI.GetComponent<GameUI>().RetryFunc();
            
            canvasUI.GetComponent<GameUI>().heart1off();
        }

        if (playerHP == 2)
        {
            canvasUI.GetComponent<GameUI>().heart3off();

        }
        if (playerHP == 1)
        {
            canvasUI.GetComponent<GameUI>().heart2off();

        }


    }
}
