using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
public class TouchController : MonoBehaviour
{
    private Camera mainCam;
    private Touch touch;
    [SerializeField] private SelectBook[] bookSelect = {};
    private void Awake() 
    {
        mainCam = Camera.main;
    }

    private void Update() 
    {
        if (Input.touchCount != 1) {return;} //detect touch
        
        //get touch input
        touch = Input.touches[0]; //first touch
        Vector3 tpos = touch.position; //register touch position into a variable

        if (touch.phase == UnityEngine.TouchPhase.Began) //if began touching screen
        {
            Ray ray = mainCam.ScreenPointToRay(tpos); //where ray is coming from
            RaycastHit hit; //variable to compare what ray hits

            //if touched any object, detect collision
            if (Physics.Raycast(ray, out hit))
            {
                //if touch tap hit trigger box, invoke event
                if (hit.collider.tag == "Trigger")
                {
                    if (bookSelect != null)
                    {
                        //temp variable to get access to the one specific object
                        var bookPick = hit.transform.GetComponent<SelectBook>(); 
                        bookPick.PickBook(); //call this function only from the ^one object we hit
                    }
                }
            }
        }
    }
}
