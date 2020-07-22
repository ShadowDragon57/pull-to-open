using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    [SerializeField]
    private LayerMask clickablesLayer; //making a layer of clickable objects

 
    void Update()
    {
        if(Input.GetMouseButtonDown(0)) //if the mouse 0 button (left click) is clicked, this if statement starts.
        {
            RaycastHit rayHit; //declaring the raycast class, this is what determines where the mouse is looking

            if(Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out rayHit, Mathf.Infinity, clickablesLayer))
            {
                //in this if statement, it is checking to see if an object of the clickablesLayer has been intersected
                //by the raycast(which follows the mouse pointer), and if so, it applies the chosen method to whatever
                //it intersected(collided) with.
                rayHit.collider.GetComponent<ClickOn>().ClickMe();
            }
        }
    }
}
