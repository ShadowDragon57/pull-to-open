using System.Collections;
using UnityEngine;

public class RaycastCamera : MonoBehaviour
{
    public GameObject wirebox;
    public GameObject WireButton;
    
    Ray ray;
    RaycastHit hit;
   
    
    // Start is called before the first frame update
    void Start()
    {
        WireButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Light wireLight = (Light)wirebox.GetComponent("Light");
        
        if (Physics.Raycast(ray, out hit) & hit.collider.name == "wirebox")
        {
            wireLight.enabled = true;
            WireButton.SetActive(true);
        }
        else
        {
            wireLight.enabled = false;
            WireButton.SetActive(false);
        }

    }
}
