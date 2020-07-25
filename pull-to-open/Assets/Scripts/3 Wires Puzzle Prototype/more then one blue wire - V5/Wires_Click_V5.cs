using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wires_Click_V5 : MonoBehaviour
{
    [SerializeField]
    private LayerMask clickablesLayer; 


    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            RaycastHit rayHit; 

            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out rayHit, Mathf.Infinity, clickablesLayer))
            {
                if (rayHit.collider.name == "SolutionWire")
                {
                    rayHit.collider.GetComponent<Wires_ClickOn_V5>().WinClick();
                }
                else
                {
                    rayHit.collider.GetComponent<Wires_ClickOn_V5>().ClickMe();
                }
            }
        }
    }
}
