using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectPage : MonoBehaviour
{
    [Header("Book Object")]
    [SerializeField] private Book book = null;

    [Header("Buttons")]
    [SerializeField] private Button leftButton = null;
    [SerializeField] private Button rightButton = null;

    [Header("Book Pages")]
    [SerializeField] private int leftPage;
    [SerializeField] private int rightPage;

    private void Start() 
    {
        //get current book page
        GetPage();
    }

    public void GetPage()
    {
        //in Book object, OnFlip() update page with GetPage()
        leftPage = book.currentPage;
        rightPage = book.currentPage + 1;
        Debug.Log("current page is " + leftPage + " and " + rightPage);

        //disable buttons on empty pages
        ButtonsActive();
    }

    public void SelectLeftPage()
    {
        switch (leftPage)
        {
            case 0:
            Debug.Log("page 0 selected");
            break;

            case 2:
            Debug.Log("page 2 selected");
            break;

            case 4:
            Debug.Log("page 4 selected");
            break;
            
            case 6:
            Debug.Log("page 6 selected");
            break;

            default:
            Debug.Log("Page " + leftPage + " is selected");
            break;
        }
    }

    public void SelectRightPage()
    {
        switch (rightPage)
        {
            case 1:
            Debug.Log("page 1 selected");
            break;

            case 3:
            Debug.Log("page 3 selected");
            break;

            case 5:
            Debug.Log("page 5 selected");
            break;
            
            case 7:
            Debug.Log("page 7 selected");
            break;

            default:
            Debug.Log("Page " + rightPage + " is selected");
            break;
        }
    }

    public void ButtonsActive()
    {
        //disable front and back buttons
        if (book.currentPage == 0 || book.currentPage == book.bookPages.Length)
        {
            leftButton.interactable = false;
            rightButton.interactable = false;
            Debug.Log("disable buttons");
        } else if ( book.currentPage != 0)
        { 
            leftButton.interactable = true;
            rightButton.interactable = true;
        }
    }
}
