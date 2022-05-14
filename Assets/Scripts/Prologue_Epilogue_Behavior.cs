using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Prologue_Epilogue_Behavior : MonoBehaviour
{
    [SerializeField]
    Canvas options, mainMenu, audioMenu;

    [SerializeField]
    Slider volumeSlider;

    [SerializeField]
    Toggle mute;

    // Start is called before the first frame update
    void Start()
    {
        options.enabled = true;
        audioMenu.enabled = false;
        mainMenu.enabled = false;


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

    public void loadMainMenuScene()
    {
        SceneManager.LoadScene("SceneMainMenu");
        Time.timeScale = 1;
    }

    public void loadLvl1Scene()
    {
        SceneManager.LoadScene("SceneLvl1");
        Time.timeScale = 1;
    }

    public void ResumeScene()
    {
        mainMenu.enabled = false;
        audioMenu.enabled = false;
        Time.timeScale = 1;
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

}
