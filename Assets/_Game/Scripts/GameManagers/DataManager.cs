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

    [Header("Book Selection Settings")]
    [SerializeField] public GameObject[] _bookShelf = {}; // book objects
    [SerializeField] public GameObject[] _bookList = {}; // book UI
    public int _currentBookID;
    public GameObject _currentBook;
    public Animator _currentBookAnim;

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

    public void SaveBookID(int bookID, SelectBook book)
    {
        _currentBookID = bookID;
        _currentBook = book.gameObject;
        Debug.Log("book selected is " + bookID.ToString());
    }

    public void OpenBook()
    {
        Debug.Log("current book id is " + _currentBookID.ToString());
        Debug.Log("open this book " + _currentBook.ToString());

        int _bookIgnore = _currentBookID;
        for (int i=0; i<_bookShelf.Length; i++)
        {
            // only the one matching i == which will be on, all others will be off
            _bookShelf[i].SetActive(i != _bookIgnore);
            Debug.Log("ignore book " + _bookIgnore);
        }

        // TO DO make coroutines to display books
        //animation to open book
        _currentBookAnim = _currentBook.gameObject.GetComponent<Animator>();
        _currentBookAnim.Play("open");

        //TO DO after opening book (wait for seconds), open book UI with switch statement
        
        for (int i=0; i<_bookList.Length; i++)
        {
            switch(_currentBookID)
            {
                case 0:
                _bookList[0].SetActive(true); // make this active
                // TO DO leave the rest deactivated
                Debug.Log(_bookList[0].ToString() + " book UI is now active");
                break;

                case 1:
                _bookList[1].SetActive(true);
                Debug.Log(_bookList[1].ToString() + " book UI is now active");
                break;

                case 2:
                _bookList[2].SetActive(true);
                Debug.Log(_bookList[2].ToString() + " book UI is now active");
                break;
            }
        }
    }
}
