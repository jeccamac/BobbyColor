using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SelectBook : MonoBehaviour
{
    private Animator animator;
    private bool isSelected;
    [SerializeField] public UnityEvent invokeMethod;
    
    private void Start() 
    {
        animator = GetComponent<Animator>();
    }
    public void PickBook()
    {
        if (animator != null)
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
}
