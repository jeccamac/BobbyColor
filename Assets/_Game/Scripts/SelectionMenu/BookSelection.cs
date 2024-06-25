using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BookSelection : MonoBehaviour
{
    [Header("Active Panels")]
    [SerializeField] private SelectPage selectPage = null;

    [Tooltip("Book game object to animate open")]
    [Header("Book Shelf")]
    [SerializeField] private GameObject[] bookShelf = {};

    [Tooltip("Book UI with page contents")]
    [Header("Book List")]
    [SerializeField] public Book[] bookList = {};
    [SerializeField] public int activeBook = 0;

    private void Start()
    {
        //disable book ui
        for (int i = 0; i < bookList.Length; i++)
        {
            bookList[i].gameObject.SetActive(false);
            //if book has not been selected, disable panel
            selectPage.gameObject.SetActive(false);
        }
    }

    public void BookSelect(int bookNo)
    {
        Debug.Log("book number id " + bookNo);
        activeBook = bookNo; //update what book was selected
        OpenActiveBook(activeBook); //open the book according to the bookID

        for (int i = 0; i < bookShelf.Length; i++)
        {
            bookShelf[i].SetActive(false); //disable book shelf display
        }

        Debug.Log("selected book " + activeBook);
    }
    public void OpenActiveBook(int bookID)
    {
        for (int i = 0; i < bookList.Length; i++)
        {
            //get active book from what was selected
            switch (bookID)
            {
                case 0:
                bookList[bookID].gameObject.SetActive(true);
                selectPage.gameObject.SetActive(true); //enable select page panel
                selectPage.GetBook(bookID); //(in SelectPage Panel) with corresponding book selection
                Debug.Log("Book " + bookList[0].name + " selected");
                break;

                case 1:
                bookList[bookID].gameObject.SetActive(true);
                selectPage.gameObject.SetActive(true); //enable select page panel
                selectPage.GetBook(bookID); //(in SelectPage Panel) with corresponding book selection
                Debug.Log("Book " + bookList[0].name + " selected");
                break;

                case 2:
                bookList[bookID].gameObject.SetActive(true);
                selectPage.gameObject.SetActive(true); //enable select page panel
                selectPage.GetBook(bookID); //(in SelectPage Panel) with corresponding book selection
                Debug.Log("Book " + bookList[0].name + " selected");
                break;

                default:
                Debug.Log("No book selected");
                break;
            }
        }
    }
}
