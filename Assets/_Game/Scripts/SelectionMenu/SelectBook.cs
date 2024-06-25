using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectBook : MonoBehaviour
{
    private Animator animator;
    private bool isSelected;

    private void Start() 
    {
        animator = this.gameObject.GetComponent<Animator>();
    }

    public void PickBook()
    {
        if (isSelected)
        {
            isSelected = false;
            //deselect animation
            if (animator != null)
            {
                animator.Play("deselect");
            }

            //enable buttons
        } else if (!isSelected)
        {
            isSelected = true;
            //select animation
            if (animator != null)
            {
                animator.Play("select");
            }

            //enable buttons
        }
    }
}
