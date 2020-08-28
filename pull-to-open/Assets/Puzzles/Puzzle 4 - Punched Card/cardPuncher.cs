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

    List<GameObject> Card = new List<GameObject>();

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

    Animator anim;
    public Animator armAnim;

    public AudioSource punchAudio;
    public AudioSource readerAudio;

    int Count = 0;

    public GameObject code;
    string password;
    string entered="";

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

        anim = this.GetComponent<Animator>();
        SetCode();
    }

    // Update is called once per frame
    void Update()
    {
        if (Count < 10)
        {
            if (Input.anyKey)
            {
                Card[Count].GetComponent<RawImage>().texture = setStrip();
            }
        }
        else if (Count == 10)
        {
            anim.SetBool("finished", true);

            if (Input.GetKeyDown(KeyCode.Return))
            {
                anim.SetTrigger("inserting");
                armAnim.SetTrigger("on");
                if (password == entered)
                {
                    Debug.Log("Complete");
                }
            }
        }
    }

    void SetCode()
    {
        int random = Random.Range(0, 8);

        switch(random)
        {
            case 0:
                code.GetComponent<Text>().text = "ZTQ03MSRL147FDCXAVKI";
                Debug.Log(random);
                password = "TH3NUMB3RS";
                break;
            case 1:
                code.GetComponent<Text>().text = "TV3RZ7XIF1SALKQ40CMD";
                Debug.Log(random);
                password = "W3CANTDO1T";
                break;
            case 2:
                code.GetComponent<Text>().text = "TS07MAF1LX3ZKIR4CVQD";
                Debug.Log(random);
                password = "WHY5S0COLD";
                break;
            case 3:
                code.GetComponent<Text>().text = "430LZ1QR7ACMVTKXSIFD";
                Debug.Log(random);
                password = "TYME70DUEL";
                break;
            case 4:
                code.GetComponent<Text>().text = "1SDQTM7ZFK34IAVRCXL";
                Debug.Log(random);
                password = "PLY0FTHGME";
                break;
            case 5:
                code.GetComponent<Text>().text = "7R3DF4ZLVQMCXT1IKSA";
                Debug.Log(random);
                password = "M0US7ASH3S";
                break;
            case 6:
                code.GetComponent<Text>().text = "KCDQXV7IFZSA4RTM31L";
                Debug.Log(random);
                password = "1R0NWAL1G0";
                break;
            case 7:
                code.GetComponent<Text>().text = "MSDFAILTQV3X1K4ZCR7";
                Debug.Log(random);
                password = "I7SDE27INY";
                break;
        }
    }

    Texture setStrip()
    {      
        if (Input.GetKeyDown(KeyCode.Alpha0) || Input.GetKeyDown("[0]"))
        {
            Count++;
            anim.SetTrigger("keyPress");
            playPunch();
            entered += "0";
            return Strip0;
            
        }
        else if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown("[1]"))
        {
            Count++;
            anim.SetTrigger("keyPress");
            playPunch();
            entered += "1";
            return Strip1;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown("[2]"))
        {
            Count++;
            anim.SetTrigger("keyPress");
            playPunch();
            entered += "2";
            return Strip2;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown("[3]"))
        {
            Count++;
            anim.SetTrigger("keyPress");
            playPunch();
            entered += "3";
            return Strip3;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4) || Input.GetKeyDown("[4]"))
        {
            Count++;
            anim.SetTrigger("keyPress");
            playPunch();
            entered += "4";
            return Strip4;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha5) || Input.GetKeyDown("[5]"))
        {
            Count++;
            anim.SetTrigger("keyPress");
            playPunch();
            entered += "5";
            return Strip5;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha6) || Input.GetKeyDown("[6]"))
        {
            Count++;
            anim.SetTrigger("keyPress");
            playPunch();
            entered += "6";
            return Strip6;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha7) || Input.GetKeyDown("[7]"))
        {
            Count++;
            anim.SetTrigger("keyPress");
            playPunch();
            entered += "7";
            return Strip7;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha8) || Input.GetKeyDown("[8]"))
        {
            Count++;
            anim.SetTrigger("keyPress");
            playPunch();
            entered += "8";
            return Strip8;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha9) || Input.GetKeyDown("[9]"))
        {
            Count++;
            anim.SetTrigger("keyPress");
            playPunch();
            entered += "9";
            return Strip9;
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            Count++;
            anim.SetTrigger("keyPress");
            playPunch();
            entered += "A";
            return StripA;
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            Count++;
            anim.SetTrigger("keyPress");
            playPunch();
            entered += "B";
            return StripB;
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            Count++;
            anim.SetTrigger("keyPress");
            playPunch();
            entered += "C";
            return StripC;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            Count++;
            anim.SetTrigger("keyPress");
            playPunch();
            entered += "D";
            return StripD;
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            Count++;
            anim.SetTrigger("keyPress");
            playPunch();
            entered += "E";
            return StripE;
        }
        else if (Input.GetKeyDown(KeyCode.F))
        {
            Count++;
            anim.SetTrigger("keyPress");
            playPunch();
            entered += "F"; 
            return StripF;
        }
        else if (Input.GetKeyDown(KeyCode.G))
        {
            Count++;
            anim.SetTrigger("keyPress");
            playPunch();
            entered += "G";
            return StripG;
        }
        else if (Input.GetKeyDown(KeyCode.H))
        {
            Count++;
            anim.SetTrigger("keyPress");
            playPunch();
            entered += "H";
            return StripH;
        }
        else if (Input.GetKeyDown(KeyCode.I))
        {
            Count++;
            anim.SetTrigger("keyPress");
            playPunch();
            entered += "I";
            return StripI;
        }
        else if (Input.GetKeyDown(KeyCode.J))
        {
            Count++;
            anim.SetTrigger("keyPress");
            playPunch();
            entered += "J";
            return StripJ;
        }
        else if (Input.GetKeyDown(KeyCode.K))
        {
            Count++;
            anim.SetTrigger("keyPress");
            playPunch();
            entered += "K";
            return StripK;
        }
        else if (Input.GetKeyDown(KeyCode.L))
        {
            Count++;
            anim.SetTrigger("keyPress");
            playPunch();
            entered += "L";
            return StripL;
        }
        else if (Input.GetKeyDown(KeyCode.M))
        {
            Count++;
            anim.SetTrigger("keyPress");
            playPunch();
            entered += "M";
            return StripM;
        }
        else if (Input.GetKeyDown(KeyCode.N))
        {
            Count++;
            anim.SetTrigger("keyPress");
            playPunch();
            entered += "N";
            return StripN;
        }
        else if (Input.GetKeyDown(KeyCode.O))
        {
            Count++;
            anim.SetTrigger("keyPress");
            playPunch();
            entered += "O";
            return StripO;
        }
        else if (Input.GetKeyDown(KeyCode.P))
        {
            Count++;
            anim.SetTrigger("keyPress");
            playPunch();
            entered += "P";
            return StripP;
        }
        else if (Input.GetKeyDown(KeyCode.Q))
        {
            Count++;
            anim.SetTrigger("keyPress");
            playPunch();
            entered += "Q";
            return StripQ;
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            Count++;
            anim.SetTrigger("keyPress");
            playPunch();
            entered += "R";
            return StripR;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            Count++;
            anim.SetTrigger("keyPress");
            playPunch();
            entered += "S";
            return StripS;
        }
        else if (Input.GetKeyDown(KeyCode.T))
        {
            Count++;
            anim.SetTrigger("keyPress");
            playPunch();
            entered += "T";
            return StripT;
        }
        else if (Input.GetKeyDown(KeyCode.U))
        {
            Count++;
            anim.SetTrigger("keyPress");
            playPunch();
            entered += "U";
            return StripU;
        }
        else if (Input.GetKeyDown(KeyCode.V))
        {
            Count++;
            anim.SetTrigger("keyPress");
            playPunch();
            entered += "V";
            return StripV;
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            Count++;
            anim.SetTrigger("keyPress");
            playPunch();
            entered += "W";
            return StripW;
        }
        else if (Input.GetKeyDown(KeyCode.X))
        {
            Count++;
            anim.SetTrigger("keyPress");
            playPunch();
            entered += "X";
            return StripX;
        }
        else if (Input.GetKeyDown(KeyCode.Y))
        {
            Count++;
            anim.SetTrigger("keyPress");
            playPunch();
            entered += "Y";
            return StripY;
        }
        else if (Input.GetKeyDown(KeyCode.Z))
        {
            Count++;
            anim.SetTrigger("keyPress");
            playPunch();
            entered += "Z";
            return StripZ;
        }
        else
        {
            return StripBlank;
        }
        
    }
    void playPunch()
    {
        punchAudio.Play(0);
    }
}
