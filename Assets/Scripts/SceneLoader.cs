using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader1 : MonoBehaviour
{
    public string MenuSceneName;
    public string PlayingSceneName;
    public string EndSceneName;
    // Start is called before the first frame update
    public static SceneLoader1 Instance { get; private set; }

    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void StartScene()
    {
        SceneManager.LoadScene(PlayingSceneName);
        Cursor.lockState = CursorLockMode.Locked;
    }
    void GoEnd()
    {
        SceneManager.LoadScene(EndSceneName);
        Cursor.lockState = CursorLockMode.None;
    }
    void GoMenu()
    {
        SceneManager.LoadScene(MenuSceneName);
        Cursor.lockState = CursorLockMode.None;
    }
}
