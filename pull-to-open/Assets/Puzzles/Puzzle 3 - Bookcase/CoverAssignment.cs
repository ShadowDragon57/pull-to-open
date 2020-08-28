using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoverAssignment : MonoBehaviour
{
    int Cover;
    public Material display;
    public Material elite;
    public Material entrance;
    public Material forward;
    public Material keep;
    public Material key;
    public Material KTANE;
    public Material not;
    public Material power;
    public Material reading;
    public Material satan;
    public Material secret;
    public Material stalin;
    public Material together;
    public Material works;

    public GameObject BigBook;

    Ray ray;
    RaycastHit hit;
    // Start is called before the first frame update
    public void coverSet(int Cover)
    {

        switch (Cover)
        {
            case 0:
                BigBook.GetComponent<Renderer>().material = display;
                break;
            case 1:
                BigBook.GetComponent<Renderer>().material = elite;
                break;
            case 2:
                BigBook.GetComponent<Renderer>().material = entrance;
                break;
            case 3:
                BigBook.GetComponent<Renderer>().material = forward;
                break;
            case 4:
                BigBook.GetComponent<Renderer>().material = keep;
                break;
            case 5:
                BigBook.GetComponent<Renderer>().material = key;
                break;
            case 6:
                BigBook.GetComponent<Renderer>().material = KTANE;
                break;
            case 7:
                BigBook.GetComponent<Renderer>().material = not;
                break;
            case 8:
                BigBook.GetComponent<Renderer>().material = power;
                break;
            case 9:
                BigBook.GetComponent<Renderer>().material = reading;
                break;
            case 10:
                BigBook.GetComponent<Renderer>().material = satan;
                break;
            case 11:
                BigBook.GetComponent<Renderer>().material = secret;
                break;
            case 12:
                BigBook.GetComponent<Renderer>().material = stalin;
                break;
            case 13:
                BigBook.GetComponent<Renderer>().material = together;
                break;
            case 14:
                BigBook.GetComponent<Renderer>().material = works;
                break;

        }
    }

    // Update is called once per frame
    void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        
        if (Physics.Raycast(ray, out hit))
        {
            Cover = hit.collider.gameObject.GetComponent<bookVariables>().cover;
            coverSet(Cover);  
        }
    }
}
