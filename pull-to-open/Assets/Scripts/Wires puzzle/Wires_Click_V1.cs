using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Wires_Click_V1 : MonoBehaviour
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
              if (rayHit.collider.CompareTag("SolutionWire"))
                {
                    rayHit.collider.GetComponent<Wires_ClickOn_V1>().WinClick();
                }                   
            }
        }
    }
}
