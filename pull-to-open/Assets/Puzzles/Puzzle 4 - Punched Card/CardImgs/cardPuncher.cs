using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cardPuncher : MonoBehaviour
{
    public GameObject CardStrip1;
    public GameObject CardStrip2;
    public GameObject CardStrip3;
    public GameObject CardStrip4;
    public GameObject CardStrip5;
    public GameObject CardStrip6;
    public GameObject CardStrip7;
    public GameObject CardStrip8;
    public GameObject CardStrip9;
    public GameObject CardStrip10;

    public Texture Strip0;
    public Texture Strip1;
    public Texture Strip2;
    public Texture Strip3;
    public Texture Strip4;
    public Texture Strip5;
    public Texture Strip6;
    public Texture Strip7;
    public Texture Strip8;
    public Texture Strip9;
    public Texture StripA;
    public Texture StripB;
    public Texture StripC;
    public Texture StripD;
    public Texture StripE;
    public Texture StripF;
    public Texture StripG;
    public Texture StripH;
    public Texture StripI;
    public Texture StripJ;
    public Texture StripK;
    public Texture StripL;
    public Texture StripM;
    public Texture StripN;
    public Texture StripO;
    public Texture StripP;
    public Texture StripQ;
    public Texture StripR;
    public Texture StripS;
    public Texture StripT;
    public Texture StripU;
    public Texture StripV;
    public Texture StripW;
    public Texture StripX;
    public Texture StripY;
    public Texture StripZ;
    public Texture StripBlank;

    List<GameObject> Card = new List<GameObject>();

    int Count = 0;

    // Start is called before the first frame update
    void Start()
    {
        Card.Add(CardStrip1);
        Card.Add(CardStrip2);
        Card.Add(CardStrip3);
        Card.Add(CardStrip4);
        Card.Add(CardStrip5);
        Card.Add(CardStrip6);
        Card.Add(CardStrip7);
        Card.Add(CardStrip8);
        Card.Add(CardStrip9);
        Card.Add(CardStrip10);
    }

    // Update is called once per frame
    void Update()
    {
        while (Count < 10)
        {
            if (Input.anyKey)
            {
                Card[Count].GetComponent<RawImage>().texture = setStrip();
            }
        }
    }

    Texture setStrip()
    {
        if (Input.GetKeyDown(KeyCode.Alpha0) || Input.GetKeyDown("[0]"))
        {
            Count++;
            return Strip0;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown("[1]"))
        {
            Count++;
            return Strip1;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown("[2]"))
        {
            Count++;
            return Strip2;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown("[3]"))
        {
            Count++;
            return Strip3;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4) || Input.GetKeyDown("[4]"))
        {
            Count++;
            return Strip4;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha5) || Input.GetKeyDown("[5]"))
        {
            Count++;
            return Strip5;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha6) || Input.GetKeyDown("[6]"))
        {
            Count++;
            return Strip6;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha7) || Input.GetKeyDown("[7]"))
        {
            Count++;
            return Strip7;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha8) || Input.GetKeyDown("[8]"))
        {
            Count++;
            return Strip8;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha9) || Input.GetKeyDown("[9]"))
        {
            Count++;
            return Strip9;
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            Count++; 
            return StripA;
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            Count++; 
            return StripB;
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            Count++; 
            return StripC;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            Count++; 
            return StripD;
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            Count++; 
            return StripE;
        }
        else if (Input.GetKeyDown(KeyCode.F))
        {
            Count++; 
            return StripF;
        }
        else if (Input.GetKeyDown(KeyCode.G))
        {
            Count++; 
            return StripG;
        }
        else if (Input.GetKeyDown(KeyCode.H))
        {
            Count++; 
            return StripH;
        }
        else if (Input.GetKeyDown(KeyCode.I))
        {
            Count++; 
            return StripI;
        }
        else if (Input.GetKeyDown(KeyCode.J))
        {
            Count++; 
            return StripJ;
        }
        else if (Input.GetKeyDown(KeyCode.K))
        {
            Count++; 
            return StripK;
        }
        else if (Input.GetKeyDown(KeyCode.L))
        {
            Count++; 
            return StripL;
        }
        else if (Input.GetKeyDown(KeyCode.M))
        {
            Count++; 
            return StripM;
        }
        else if (Input.GetKeyDown(KeyCode.N))
        {
            Count++; 
            return StripN;
        }
        else if (Input.GetKeyDown(KeyCode.O))
        {
            Count++; 
            return StripO;
        }
        else if (Input.GetKeyDown(KeyCode.P))
        {
            Count++; 
            return StripP;
        }
        else if (Input.GetKeyDown(KeyCode.Q))
        {
            Count++; 
            return StripQ;
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            Count++; 
            return StripR;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            Count++; 
            return StripS;
        }
        else if (Input.GetKeyDown(KeyCode.T))
        {
            Count++; 
            return StripT;
        }
        else if (Input.GetKeyDown(KeyCode.U))
        {
            Count++; 
            return StripU;
        }
        else if (Input.GetKeyDown(KeyCode.V))
        {
            Count++; 
            return StripV;
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            Count++; 
            return StripW;
        }
        else if (Input.GetKeyDown(KeyCode.X))
        {
            Count++; 
            return StripX;
        }
        else if (Input.GetKeyDown(KeyCode.Y))
        {
            Count++; 
            return StripY;
        }
        else if (Input.GetKeyDown(KeyCode.Z))
        {
            Count++; 
            return StripZ;
        }
        else
        {
            return StripBlank;
        }
        
    }
}
