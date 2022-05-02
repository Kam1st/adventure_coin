using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Lvl1_Behavior : MonoBehaviour
{
    [SerializeField]
    Canvas mainMenu, audioMenu;

    [SerializeField]
    Slider volumeSlider;

    [SerializeField]
    Toggle mute;

    // Start is called before the first frame update
    void Start()
    {
        mainMenu.enabled = false;
        audioMenu.enabled = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            mainMenu.enabled = true;
            audioMenu.enabled = false;
            Time.timeScale = 0;
        }

    }

    public void LVL_Quit()
    {
        Application.Quit();
    }

    public void changeVolume()
    {
        
        if (mute.isOn)
        {
            AudioListener.volume = 0;
        }
        else
        {
            AudioListener.volume = volumeSlider.value;
        } 
    }

    public void loadMainMenuScene()
    {
        SceneManager.LoadScene("SceneMainMenu");
    }

    public void loadPrologueScene()
    {
        SceneManager.LoadScene("ScenePrologue");
    }

    public void loadLvl1Scene()
    {
        SceneManager.LoadScene("SceneLvl1");
    }

    public void ResumeScene()
    {
        mainMenu.enabled = false;
        audioMenu.enabled = false;
        Time.timeScale = 1;
    }

    public void loadLvl2Scene()
    {
        SceneManager.LoadScene("SceneLvl2");
    }

    public void loadLvl3Scene()
    {
        SceneManager.LoadScene("SceneLvl3");
    }

    /*  public void loadLvl4Scene()
      {
          SceneManager.LoadScene("SceneLvl4");
      } */

    public void loadEpilogueScene()
    {
        SceneManager.LoadScene("SceneEpilogue");
    }
}