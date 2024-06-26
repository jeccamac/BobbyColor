using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance = null; // Singleton Instance

    [Header("Scene Settings")]
    [SerializeField] private SceneLoader _sceneLoader = null;
    public static SceneLoader SceneLoader => Instance._sceneLoader;
    public string level {get; set;} //current level room

    private void Awake()
    {
        // Singleton pattern, should only be one of these instances on the DataManager prefab
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        } else { Destroy(this.gameObject); }

        if (_sceneLoader == null)
        {
            _sceneLoader = GetComponentInChildren<SceneLoader>();
        }
    }

    // get enums here with functions and switch
    public Room GetRoom()
    {
        switch (level)
        {
            case "MainScreen":
                return Room.MainScreen;
            case "SelectionMenu":
                return Room.SelectionMenu;
            case "PaintBoard":
                return Room.PaintBoard;
            default:
                return Room.None;
        }
    }
}
