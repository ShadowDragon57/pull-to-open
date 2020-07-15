using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wires_Click_V2 : MonoBehaviour
{
    [SerializeField]
    private LayerMask clickablesLayer;

    private bool wrongClicked;
    private GameObject[] wires;
    void Start()
    {
        wrongClicked = false;
        wires = GameObject.FindGameObjectsWithTag("Wire");
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
                        if(wires.Length == 7)
                        {                            
                            rayHit.collider.GetComponent<Wires_ClickOn_V2>().WinClick();

                        }
                        else
                        {
                            rayHit.collider.GetComponent<Wires_ClickOn_V2>().ClickMe();
                        }
                    }
                    if(wrongClicked == true)
                    {
                        rayHit.collider.GetComponent<Wires_ClickOn_V2>().ClickMe();
                    }
                }
              if(rayHit.collider.CompareTag("Wire"))
                {
                    wrongClicked = true;
                    rayHit.collider.GetComponent<Wires_ClickOn_V2>().ClickMe();
                }
            }
        }
    }
}
