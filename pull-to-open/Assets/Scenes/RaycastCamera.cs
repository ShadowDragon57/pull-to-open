using System.Collections;
using UnityEngine;

public class RaycastCamera : MonoBehaviour
{
    public GameObject wirebox;
    
    Ray ray;
    RaycastHit hit;
   
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Light wireLight = (Light)wirebox.GetComponent("Light");
        
        if (Physics.Raycast(ray, out hit))
        {
            wireLight.enabled = true;
        }
        else
        {
            wireLight.enabled = false;
        }

    }
}
