using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManger : MonoBehaviour
{

    public GameObject newgame = null;
    public GameObject options=null;
    public GameObject about=null;
    public GameObject exit;


    public void ExitGame() 
    {
        //UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }

    public void CallNew() => NewGame();

    public void NewGame()
    {
        SceneManager.LoadScene(1);
    }

    // Start is called before the first frame update
    void Start()
    {
           
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
