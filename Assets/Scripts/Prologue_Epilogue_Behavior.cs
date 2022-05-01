using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Prologue_Epilogue_Behavior : MonoBehaviour
{
    [SerializeField]
    Canvas options;
    // Start is called before the first frame update
    void Start()
    {
        options.enabled = true;
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

}
