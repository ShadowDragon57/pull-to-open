using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class RaycastCamera : MonoBehaviour
{
    //Navigation Buttons
    public GameObject LLeft;
    public GameObject LRight;
    public GameObject LFront;
    public GameObject LBack;
    public GameObject RLeft;
    public GameObject RRight;
    public GameObject RFront;
    public GameObject RBack;

    //Puzzle Buttons
    public GameObject WireButton;
    public GameObject BookcaseButton;
    public GameObject CardsButton;
    public GameObject PunchedButton;
    
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

        //Room Navigation UI
        if (Physics.Raycast(ray, out hit) & hit.collider.name == "L-Left Wall")
        {
            LLeft.SetActive(true);
        }
        else if (Physics.Raycast(ray, out hit) & hit.collider.name == "L-Right Wall")
        {
            LRight.SetActive(true);
        }
        else if (Physics.Raycast(ray, out hit) & hit.collider.name == "L-Front Wall")
        {
            LFront.SetActive(true);
        }
        else if (Physics.Raycast(ray, out hit) & hit.collider.name == "L-Back Wall")
        {
            LBack.SetActive(true);
        }
        else if (Physics.Raycast(ray, out hit) & hit.collider.name == "R-Left Wall")
        {
            RLeft.SetActive(true);
        }
        else if (Physics.Raycast(ray, out hit) & hit.collider.name == "R-Right Wall")
        {
            RRight.SetActive(true);
        }
        else if (Physics.Raycast(ray, out hit) & hit.collider.name == "R-Front Wall")
        {
            RFront.SetActive(true);
        }
        else if (Physics.Raycast(ray, out hit) & hit.collider.name == "R-Back Wall")
        {
            RBack.SetActive(true);
        }
        else
        {
            LLeft.SetActive(false);
            LRight.SetActive(false);
            LFront.SetActive(false);
            LBack.SetActive(false);
            RLeft.SetActive(false);
            RRight.SetActive(false);
            RFront.SetActive(false);
            RBack.SetActive(false);
        }

        //Puzzle UI
        Debug.Log(hit.collider.name);

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
        else if (Physics.Raycast(ray, out hit) & hit.collider.name == "punchcardreader")
        {
            PunchedButton.SetActive(true);
        }
        else
        {
            WireButton.SetActive(false);
            CardsButton.SetActive(false);
            BookcaseButton.SetActive(false);
            PunchedButton.SetActive(false);
        }

    }
}
