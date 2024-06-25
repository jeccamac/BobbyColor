using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BookSelection : MonoBehaviour
{
    [Header("Active Panels")]
    [SerializeField] private SelectPage selectPage = null;

    [Header("Book Select")]
    [Tooltip("Book game object to animate and open")]
    [SerializeField] private GameObject[] bookSelect = {};

    [Header("Book List")]
    [Tooltip("Book UI with page contents")]
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
        //update what book was selected
        activeBook = bookNo;
        for (int i = 0; i < bookSelect.Length; i++)
        {
            bookSelect[i].SetActive(false); //disable book displays
        }
        OpenActiveBook(activeBook);
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
                //play idle animations here?
                Debug.Log("No book selected");
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
