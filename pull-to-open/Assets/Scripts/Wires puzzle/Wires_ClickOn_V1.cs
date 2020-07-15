using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Wires_ClickOn_V1 : MonoBehaviour
{
    [SerializeField]
    private Material red;
    [SerializeField]
    private Material green;

    private MeshRenderer wireRend;

    void Start()
    {
        wireRend = GetComponent<MeshRenderer>();
    }

    public void ClickMe()
    {
        wireRend.material = green;
    }

    public void WinClick()
    {
        GameObject[] winWires;
        winWires = GameObject.FindGameObjectsWithTag("SolutionWire");
        foreach (GameObject solutionWire in winWires)
        {
            wireRend.material = green;
        }
    }
}
