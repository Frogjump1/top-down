using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    public GameObject retryUI;
    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;
    
    public bool heart2con;
    public bool heart3con;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Retry()
    {
        SceneManager.LoadScene("Game1");
        Time.timeScale = 1.0f;      
    }

    public void RetryFunc()
    {
        retryUI.SetActive(true);  
    }

    public void heart3off()
    {
        heart3.SetActive(false);
        heart3con = false;
    }
    public void heart2off()
    {
        heart2.SetActive(false);
        heart2con = false;
    }public void heart1off()
    {
        heart1.SetActive(false);

    }

    void thing()
    {
    }
}
