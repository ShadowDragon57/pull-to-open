using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wires_Click_V1 : MonoBehaviour
{
    [SerializeField]
    private LayerMask clickablesLayer;

    private bool rightClicked, wrongClicked;
    void Start()
    {
        rightClicked = false;
        wrongClicked = false;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit rayHit;

            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out rayHit, Mathf.Infinity, clickablesLayer))
            {
              if (rayHit.collider.CompareTag("SolutionWire"))
                {                    
                    if(wrongClicked == false)
                    {
                        rayHit.collider.GetComponent<Wires_ClickOn_V1>().WinClick();
                    }
                    if(wrongClicked == true)
                    {
                        rayHit.collider.GetComponent<Wires_ClickOn_V1>().ClickMe();
                    }
                }
              if(rayHit.collider.CompareTag("Wire"))
                {
                    wrongClicked = true;
                    rayHit.collider.GetComponent<Wires_ClickOn_V1>().ClickMe();
                }
            }
        }
    }
}
