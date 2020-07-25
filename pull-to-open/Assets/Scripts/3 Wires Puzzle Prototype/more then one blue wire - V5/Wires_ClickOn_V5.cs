using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Wires_ClickOn_V5 : MonoBehaviour
{
    [SerializeField] 
    private Material gone;
    [SerializeField]
    private GameObject redLight;

    private MeshRenderer myRend;

    void Start()
    {
        myRend = GetComponent<MeshRenderer>();
        redLight.SetActive(true);
    }

    public void WinClick()
    {
        GameObject[] blueWires = GameObject.FindGameObjectsWithTag("BlueWire");
        myRend.material = gone;
        if(blueWires.Length > 1)
        {
            redLight.SetActive(false);
        }
    }

    public void ClickMe()
    {
        myRend.material = gone; 
    }
}
