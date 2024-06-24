using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectBook : MonoBehaviour
{
    [Header("Active Panels")]
    [SerializeField] private SelectPage selectPage = null;

    [Header("Book Button Select")]
    [SerializeField] private Button[] bookButtons = {};

    [Header("Book List")]
    [SerializeField] public Book[] books = {};
    [SerializeField] public int activeBook = 0;

    private void Start()
    {
        //disable book view
        for (int i = 0; i < books.Length; i++)
        {
            books[i].gameObject.SetActive(false);
            //if book has not been selected, disable panel
            selectPage.gameObject.SetActive(false);
        }

        OpenActiveBook();
    }

    public void SelectBook1()
    {
        //update what book was selected
        activeBook = 1;
        Debug.Log("selected book " + activeBook);
        OpenActiveBook();
    }

    public void SelectBook2()
    {
        activeBook = 2;
        Debug.Log("selected book " + activeBook);
        OpenActiveBook();
    }

    public void OpenActiveBook()
    {
        for (int i = 0; i < books.Length; i++)
        {
            for (int j = 0; j < bookButtons.Length; j++)
            {
                //get active book from what was selected
                switch (activeBook)
                {
                    case 0:
                    //play idle animations here?
                    Debug.Log("No book selected");
                    break;

                    case 1:
                    books[0].gameObject.SetActive(true);
                    bookButtons[j].gameObject.SetActive(false);
                    Debug.Log("Book " + books[0].name + " selected");
                    break;

                    case 2:
                    books[1].gameObject.SetActive(true);
                    bookButtons[j].gameObject.SetActive(false);
                    Debug.Log("Book " + books[1].name + " selected");
                    break;

                    default:
                    Debug.Log("No book selected");
                    break;
                }
            }

            //enable select page panel
            selectPage.gameObject.SetActive(true);
            //(in SelectPage Panel) with corresponding book selection
        }
    }
}
