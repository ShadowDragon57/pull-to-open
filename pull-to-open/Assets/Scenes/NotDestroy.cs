using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotDestroy : MonoBehaviour
{
    static NotDestroy instance;
    public GameObject puzzleDisplay1;
    public GameObject puzzleDisplay2;
    public GameObject puzzleDisplay3;
    public GameObject puzzleDisplay4;
    public GameObject puzzleDisplay5;
    public GameObject puzzleDisplay6;

    List<GameObject> puzzlesUI = new List<GameObject>();

    public GameObject WirePuzzle;
    public GameObject BookcasePuzzle;
    public GameObject CardsPuzzle;
    public GameObject PunchedPuzzle;
    public GameObject SafePuzzle;
    public GameObject PhonePuzzle;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (instance != this)
        {
            //gameObject.SetActive(false);
            Destroy(gameObject);
            ReEnterRoom();
        }
    }
    
    void loadList()
    {
        puzzlesUI.Add(puzzleDisplay1);
        puzzlesUI.Add(puzzleDisplay2);
        puzzlesUI.Add(puzzleDisplay3);
        puzzlesUI.Add(puzzleDisplay4);
        puzzlesUI.Add(puzzleDisplay5);
        puzzlesUI.Add(puzzleDisplay6);
    }
  
    void ReEnterRoom()
    {
        loadList();
        loadPuzzle();
    }

    public void loadPuzzle()
    {
        loadList();
        WirePuzzle.SetActive(false);
        CardsPuzzle.SetActive(false);
        BookcasePuzzle.SetActive(false);
        PunchedPuzzle.SetActive(false);
        SafePuzzle.SetActive(false);
        PhonePuzzle.SetActive(false);

        for (int i = 0; i < 6; i++)
        {
            if (puzzlesUI[i].activeInHierarchy == true)
            {
                switch (puzzlesUI[i].GetComponent<UIVariables>().puzzle)
                {
                    case "wires":
                        WirePuzzle.SetActive(true);
                        break;
                    case "cards":
                        CardsPuzzle.SetActive(true);
                        break;
                    case "bookcase":
                        BookcasePuzzle.SetActive(true);
                        break;
                    case "punchreader":
                        PunchedPuzzle.SetActive(true);
                        break;
                    case "safe":
                        SafePuzzle.SetActive(true);
                        break;
                    case "phone":
                        PhonePuzzle.SetActive(true);
                        break;
                }
            }
        }
    }
}
