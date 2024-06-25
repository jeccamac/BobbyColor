using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectBook : MonoBehaviour
{
    private Animator animator;

    private void Start() 
    {
        animator = this.gameObject.GetComponent<Animator>();
    }

    public void PickBook()
    {
        Debug.Log("tap on book");
        if (animator != null)
        {
            animator.Play("select");
            Debug.Log("play select animation");
        }
    }
}
