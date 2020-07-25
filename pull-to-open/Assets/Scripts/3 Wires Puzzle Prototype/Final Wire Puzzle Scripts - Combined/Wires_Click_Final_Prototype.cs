using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Wires_Click_Final_Prototype : MonoBehaviour
{
    [SerializeField]
    private LayerMask clickablesLayer; //Declaring the layer of clickable objects to be set in Unity.
    [SerializeField]
    private Text clock;

    private MeshRenderer wireRend; //Declaring the renderer to use later.


    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //Checks every frame to see if the left mouse button has been clicked.
        {
            RaycastHit rayHit; //Declaring the RayCast variable, this is what projects from the camera and determines- 
                               //-what has been clicked on.
            Debug.Log("click");
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out rayHit, Mathf.Infinity, clickablesLayer)) 
                //When the left mouse button is clicked, if all the parameters are met, it allows the code to move forward.
            {
                Debug.Log("click1");
                wireRend = rayHit.collider.GetComponent<MeshRenderer>();
                if (rayHit.collider.name == "SolutionWire") //If the player clicks the wire that is named SolutionWire,- 
                                                            //-it calls the WinClick method in the "ClickOn" class.
                {                    
                    rayHit.collider.GetComponent<Wires_ClickOn_Final_Prototype>().WinClick(wireRend);
                }
                else //If the player clicks any other wire, calls the ClickMe method from the "ClickOn" class.
                {
                    rayHit.collider.GetComponent<Wires_ClickOn_Final_Prototype>().ClickMe(wireRend);
                }
            }
        }
    }
}
