using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wires_ClickOn_V2 : MonoBehaviour
{
    [SerializeField]
    private Material red;
    [SerializeField]
    private Material green;

    private MeshRenderer wireRend;

    public GameObject redLight;

    void Start()
    {
        redLight.SetActive(true);
        wireRend = GetComponent<MeshRenderer>();
    }

    public void ClickMe()
    {
        wireRend.material = green;
    }

    public void WinClick()
    {
        wireRend.material = green;
        redLight.SetActive(false);
    }
}
