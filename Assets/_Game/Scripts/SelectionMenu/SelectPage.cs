using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectPage : MonoBehaviour
{
    [Header("Book Object")]
    [SerializeField] private BookSelection selectBook;
    [SerializeField] private Book currentBook = null;

    [Header("Buttons")]
    [SerializeField] private Button leftButton = null;
    [SerializeField] private Button rightButton = null;

    [Header("Book Pages")]
    [SerializeField] private int leftPage;
    [SerializeField] private int rightPage;

    public void GetBook(int book)
    {
        if (currentBook == null)
        {
            //get current book from active book
            switch (book)
            {
                    case 0:
                    Debug.Log("nothing selected");
                    break;

                    case 1:
                    currentBook = selectBook.bookList[1];

                    Debug.Log("what is " + currentBook.name);
                    //get current book page
                    GetPage();
                    break;

                    case 2:
                    currentBook = selectBook.bookList[2];
                    Debug.Log("what is " + currentBook.name);
                    //get current book page
                    GetPage();
                    break;

                    default:
                    Debug.Log("well poop");
                    break;
            }            
        }
    }

    public void GetPage()
    {
        //in Book object, OnFlip() update page with GetPage()
        leftPage = currentBook.currentPage;
        rightPage = currentBook.currentPage + 1;
        Debug.Log("current page is " + leftPage + " and " + rightPage);

        //disable buttons on empty pages
        ButtonsActive();
    }

    public void SelectLeftPage()
    {
        switch (leftPage)
        {
            case 0:
            Debug.Log("Page " + leftPage + " of book " + currentBook + " is selected");
            break;

            case 2:
            Debug.Log("Page " + leftPage + " of book " + currentBook + " is selected");
            break;

            case 4:
            Debug.Log("Page " + leftPage + " of book " + currentBook + " is selected");
            break;
            
            case 6:
            Debug.Log("Page " + leftPage + " of book " + currentBook + " is selected");
            break;

            default:
            Debug.Log("Page " + leftPage + " of book " + currentBook + " is selected");
            break;
        }
    }

    public void SelectRightPage()
    {
        switch (rightPage)
        {
            case 1:
            Debug.Log("Page " + rightPage + " of book " + currentBook + " is selected");
            break;

            case 3:
            Debug.Log("Page " + rightPage + " of book " + currentBook + " is selected");
            break;

            case 5:
            Debug.Log("Page " + rightPage + " of book " + currentBook + " is selected");
            break;
            
            case 7:
            Debug.Log("Page " + rightPage + " of book " + currentBook + " is selected");
            break;

            default:
            Debug.Log("Page " + rightPage + " of book " + currentBook + " is selected");
            break;
        }
    }

    public void ButtonsActive()
    {
        //disable front and back buttons
        if (currentBook.currentPage == 0 || currentBook.currentPage == currentBook.bookPages.Length)
        {
            leftButton.interactable = false;
            rightButton.interactable = false;
            Debug.Log("disable buttons");
        } else if ( currentBook.currentPage != 0 || currentBook.currentPage != currentBook.bookPages.Length)
        { 
            leftButton.interactable = true;
            rightButton.interactable = true;
        }
    }
}
