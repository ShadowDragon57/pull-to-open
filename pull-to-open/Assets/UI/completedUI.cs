using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class completedUI : MonoBehaviour
{
    public Texture wires;
    public Texture cards;
    public Texture books;
    public Texture punched;
    public Texture safe;
    public Texture phone;


    // Update is called once per frame
    void Update()
    {
        for (int i=0; i<6; i++)
        {
            if (this.GetComponent<UIVariables>().completed == true)
            {
                switch (this.GetComponent<UIVariables>().puzzle)
                {
                    case "wires":
                        this.GetComponent<RawImage>().texture = wires;
                        break;
                    case "cards":
                        this.GetComponent<RawImage>().texture = cards;
                        break;
                    case "bookcase":
                        this.GetComponent<RawImage>().texture = books;
                        break;
                    case "punchreader":
                        this.GetComponent<RawImage>().texture = punched;
                        break;
                    case "safe":
                        this.GetComponent<RawImage>().texture = safe;
                        break;
                    case "phone":
                        this.GetComponent<RawImage>().texture = phone;
                        break;
                }
            }
        }
    }
}
