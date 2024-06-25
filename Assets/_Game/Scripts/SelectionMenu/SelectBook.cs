using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class SelectBook : MonoBehaviour
{
    private Animator animator;
    private bool isSelected;
    [SerializeField] public int bookId;
    private GameObject selectBook;
    private Button selectBookBtn;
    private BookSelection bookSelection;
    private void Start() 
    {
        bookSelection = GameObject.Find("BookSelection").GetComponent<BookSelection>();
        selectBook = GameObject.Find("SelectBook_Btn");
        selectBookBtn = selectBook.GetComponent<Button>();
        animator = GetComponent<Animator>();
    }
    public void PickBook()
    {
        if (animator != null)
        {
            if (isSelected)
            {
                //TO DO - only one object selected at a time


                isSelected = false;
                //deselect animation
                if (animator != null)
                {
                    animator.Play("deselect");
                }

                selectBookBtn.interactable = false;
            } else if (!isSelected)
            {
                isSelected = true;
                //select animation
                if (animator != null)
                {
                    animator.Play("select");
                }
                Debug.Log("book id " + bookId);
                //enable button
                selectBookBtn.interactable = true;
            }
        }
    }

    public void SetBookID(int buttonId) //<--------- TO DO need a data manager and enums to save ids like this
    {
        //test book id attached to button
        Debug.Log("continue with book Id " + buttonId + " selection");
        //connect bookID to button to BookSelection
        //bookSelection.BookSelect(bookId);
    }
}
