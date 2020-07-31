using System.Collections;
using UnityEngine;

public class RaycastCamera : MonoBehaviour
{
    //public GameObject wirebox;
    public GameObject WireButton;
    public GameObject BookcaseButton;
    public GameObject CardsButton;
    
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
        
        if (Physics.Raycast(ray, out hit) & hit.collider.name == "wirebox")
        { 
            WireButton.SetActive(true);
        }
        else if (Physics.Raycast(ray, out hit) & hit.collider.name == "cards")
        {
            CardsButton.SetActive(true);
        }
        else if(Physics.Raycast(ray, out hit) & hit.collider.name == "bookcase")
        {
            BookcaseButton.SetActive(true);
        }
        else
        {
            WireButton.SetActive(false);
            CardsButton.SetActive(false);
            BookcaseButton.SetActive(false);
        }

    }
}
