using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class SelectBook : MonoBehaviour
{
    [SerializeField] public BookID bookID;
    private Animator animator;
    private bool isSelected;
    private GameObject selectBtn;
    private Button continueBtn;
    private BookSelection bookSelection;
    private void Start() 
    {
        bookSelection = GameObject.Find("BookSelection").GetComponent<BookSelection>();
        selectBtn = GameObject.Find("SelectBook_Btn");
        continueBtn = selectBtn.GetComponent<Button>();
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

                continueBtn.interactable = false;
            } else if (!isSelected)
            {
                isSelected = true;
                //select animation
                if (animator != null)
                {
                    animator.Play("select");
                }

                // save book id
                switch (bookID)
                {
                    case BookID.Book1:
                    DataManager.Instance.SaveBookID(bookID, this);
                    break;

                    case BookID.Book2:
                    DataManager.Instance.SaveBookID(bookID, this);
                    break;

                    case BookID.Book3:
                    DataManager.Instance.SaveBookID(bookID, this);
                    break;

                    default:
                    break;
                }

                //TO DO test book id attached to button
                //connect bookID to button to BookSelection
                //bookSelection.BookSelect(bookId);


                Debug.Log("book id " + bookID.ToString());
                //enable button
                continueBtn.interactable = true;
            }
        }
    }
}
