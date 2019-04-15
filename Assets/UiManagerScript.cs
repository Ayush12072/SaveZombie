using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UiManagerScript : MonoBehaviour
{
    //public static UiManager instance;
    public GameObject startPanel;
    public GameObject gameOverPanel;
    

    void Awake(){
        // if(instance == null){
        //     instance = null;
        // }
    }

    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    public void GameStart(){
        //startPanel.GetComponent<Animator>().Play("landscape");
    }

    public void GameOver(){
        gameOverPanel.SetActive(true);
    }

    public void Reset(){
        SceneManager.LoadScene(0);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
