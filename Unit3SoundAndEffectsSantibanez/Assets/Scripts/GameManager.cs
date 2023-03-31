using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private PlayerController playerControllerscript;

    
    // Start is called before the first frame update
     public void Restart()
     {
       
        playerControllerscript.gameOver = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    void Start()
    {
        playerControllerscript = GameObject.Find("Player").GetComponent<PlayerController>();
    }
   
    // Update is called once per frame
    void Update()
    {
        
    }
   
}
