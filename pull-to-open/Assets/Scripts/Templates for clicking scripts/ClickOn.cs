using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickOn : MonoBehaviour
{
    [SerializeField] //serializing field allows it to be seen in unity but still remain private.
    private Material red;
    [SerializeField]
    private Material green;

   
    GameObject icon;


    private MeshRenderer myRend;

    void Start()
    {
        myRend = GetComponent<MeshRenderer>(); //gets the colour of whatever component the Click class has collided with.
    }

    public void ClickMe() 
    {
        myRend.material = green; //changes the colour of whatever component the Click class has collided with.
        icon = GameObject.FindWithTag("WireIcon");
        icon.GetComponent<UIVariables>().completed = true;
    }
}
