using System.Collections;
using System.Collections;
using UnityEngine;

public class RaycastCamera : MonoBehaviour
{
    public GameObject wiresLight;
    
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
        Light wireLight = wiresSelectLight.GetComponent("Light");
        
        if (Physics.Raycast(ray, out hit))
        {
            wireLight.enabled = !wireLight.enabled;
        }
    }
}
