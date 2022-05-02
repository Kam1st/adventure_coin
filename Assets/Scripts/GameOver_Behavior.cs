using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver_Behavior : MonoBehaviour
{

    [SerializeField]
    Canvas gameOver;


    // Start is called before the first frame update
    void Start()
    {
        gameOver.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void loadMainMenuScene()
    {
        SceneManager.LoadScene("SceneMainMenu");
    }

    public void loadLvl1Scene()
    {
        SceneManager.LoadScene("SceneLvl1");
    }

    public void loadLvl2Scene()
    {
        SceneManager.LoadScene("SceneLvl2");
    }

    public void loadLvl3Scene()
    {
        SceneManager.LoadScene("SceneLvl3");
    }

}
