using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour
{
    public static ScenesManager Instance;

    // Start is called before the first frame update
    void Awake()
    {
        Instance = this;
    }

    public enum Scene
    {
        MainMenu,
        SampleScene
    }

    void LoadScene(Scene scene)
    {
        SceneManager.LoadScene(scene.ToString());
    }

    void LoadMainMenu()
    {
        SceneManager.LoadScene(Scene.MainMenu.ToString());
    }

    void LoadNewGame()
    {
        SceneManager.LoadScene(Scene.SampleScene.ToString());
    }
    
}
