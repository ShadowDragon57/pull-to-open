using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Wires_ClickOn_V4 : MonoBehaviour
{
    [SerializeField]
    private Material gone;
    [SerializeField]
    private GameObject redLight;
    [SerializeField]
    private GameObject[] wires = new GameObject[7];

    private MeshRenderer myRend;


    void Start()
    {
        myRend = GetComponent<MeshRenderer>();
        redLight.SetActive(true);
    }
    public void WinClick()
    {
        myRend.material = gone;
        if (wires.Last<GameObject>().tag.Contains("White"))
        {        
            redLight.SetActive(false);        
        }
    }

    public void ClickMe()
    {
        myRend.material = gone; 
    }
}
