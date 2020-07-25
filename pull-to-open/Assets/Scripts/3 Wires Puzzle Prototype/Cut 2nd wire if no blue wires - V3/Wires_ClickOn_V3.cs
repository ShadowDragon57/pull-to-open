using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wires_ClickOn_V3 : MonoBehaviour
{
    private MeshRenderer wireRend;

    public Material gone;

    public GameObject redLight;

    void Start()
    {
        wireRend = GetComponent<MeshRenderer>();
        redLight.SetActive(true);
    }
    public void WinClick()
    {
        if(GameObject.FindGameObjectsWithTag("BlueWire").Length >= 1)
        {
            wireRend.material = gone;
        }
        else
        {
            wireRend.material = gone;
            redLight.SetActive(false);
        }
    }

    public void ClickMe()
    {
        wireRend.material = gone;
    }
}
