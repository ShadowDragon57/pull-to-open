using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookMaker : MonoBehaviour
{

    public GameObject Book1;
    public GameObject Book2;
    public GameObject Book3;
    public GameObject Book4;
    public GameObject Book5;
    public GameObject Book6;
    public GameObject Book7;
    public GameObject Book8;
    public GameObject Book9;
    public GameObject Book10;
    public GameObject Book11;
    public GameObject Book12;
    public GameObject Book13;
    public GameObject Book14;
    public GameObject Book15;

    List<GameObject> books = new List<GameObject>();

    public Material red;
    public Material blue;
    public Material green;
    public Material yellow;
    public Material black;
    public Material white;

    int colourRandom;
    Material coverColour;

    public void Start()
    {
        books.Add(Book1);
        books.Add(Book2);
        books.Add(Book3);
        books.Add(Book4);
        books.Add(Book5);
        books.Add(Book6);
        books.Add(Book7);
        books.Add(Book8);
        books.Add(Book9);
        books.Add(Book10);
        books.Add(Book11);
        books.Add(Book12);
        books.Add(Book13);
        books.Add(Book14);
        books.Add(Book15);

        
        for (int i=0; i<15; i++)
        {
            colourRandom = Random.Range(0, 6);
            books[i].GetComponent<Renderer>().material = bookColour(colourRandom);
            books[i].GetComponent<bookVariables>().colour = colourRandom;
            books[i].GetComponent<bookVariables>().cover = Random.Range(0, 14);
        }
        
    }
    

    // Start is called before the first frame update
    Material bookColour(int colour)
    {
        switch (colour)
        {
            case 0: coverColour = red;
                break;
            case 1: coverColour = blue;
                break;
            case 2: coverColour = green;
                break;
            case 3: coverColour = yellow;
                break;
            case 4: coverColour = black;
                break;
            case 5: coverColour = white;
                break;
        }

        return coverColour;
    }

    
}
