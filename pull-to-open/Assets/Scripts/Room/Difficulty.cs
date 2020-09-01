using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Difficulty : MonoBehaviour
{
    List<string> puzzles = new List<string>();

    public GameObject puzzleDisplay1;
    public GameObject puzzleDisplay2;
    public GameObject puzzleDisplay3;
    public GameObject puzzleDisplay4;
    public GameObject puzzleDisplay5;
    public GameObject puzzleDisplay6;

    List<GameObject> puzzlesUI = new List<GameObject>();

    public Texture wires;
    public Texture cards;
    public Texture books;
    public Texture punched;
    public Texture safe;
    public Texture phone;

    public GameObject timer;

    void Start()
    {
        puzzlesUI.Add(puzzleDisplay1);
        puzzlesUI.Add(puzzleDisplay2);
        puzzlesUI.Add(puzzleDisplay3);
        puzzlesUI.Add(puzzleDisplay4);
        puzzlesUI.Add(puzzleDisplay5);
        puzzlesUI.Add(puzzleDisplay6);        
    }

    public void LoadPuzzles()
    {
        puzzles.Add("wirebox");
        puzzles.Add("cards");
        puzzles.Add("bookcase");
        puzzles.Add("punchreader");
        //puzzles.Add("safe");
        //puzzles.Add("phone");
    }

    void Update()
    {
            
    }

    void ShufflePuzzles<T>(List<T> puzzlesList)
    {
        System.Random random = new System.Random();
        
        for (int i=0; i<4; i++)
        {
            int j = random.Next(i+1);
            var temp = puzzlesList[i];
            puzzlesList[i] = puzzlesList[j];
            puzzlesList[j] = temp;
        }
    }
    
    public void easyDiff()
    {
        LoadPuzzles();
        ShufflePuzzles(puzzles);
        spawnPuzzles(2, puzzles);
        timer.GetComponent<timer>().timerIsRunning = true;
    }

    public void mediumDiff()
    {
        LoadPuzzles();
        ShufflePuzzles(puzzles);
        spawnPuzzles(3, puzzles);
        timer.GetComponent<timer>().timerIsRunning = true;
    }

    public void hardDiff()
    {
        LoadPuzzles();
        ShufflePuzzles(puzzles);
        spawnPuzzles(4, puzzles);
        timer.GetComponent<timer>().timerIsRunning = true;
    }

    public void spawnPuzzles(int diff, List<string> puzzles)
    {
        puzzleDisplay1.SetActive(false);
        puzzleDisplay2.SetActive(false);
        puzzleDisplay3.SetActive(false);
        puzzleDisplay4.SetActive(false);
        puzzleDisplay5.SetActive(false);
        puzzleDisplay6.SetActive(false);

        for (int i = 0; i < diff; i++)
        {
            puzzlesUI[i].SetActive(true);
            switch (puzzles[i])
            {
                case "wirebox":
                    puzzlesUI[i].GetComponent<RawImage>().texture = wires;
                    puzzlesUI[i].GetComponent<UIVariables>().puzzle = "wires";
                    puzzlesUI[i].GetComponent<UIVariables>().completed = false;
                    puzzlesUI[i].tag = "WiresIcon";
                    break;
                case "cards":
                    puzzlesUI[i].GetComponent<RawImage>().texture = cards;
                    puzzlesUI[i].GetComponent<UIVariables>().puzzle = "cards";
                    puzzlesUI[i].GetComponent<UIVariables>().completed = false;
                    puzzlesUI[i].tag = "CardsIcon";
                    break;
                case "bookcase":
                    puzzlesUI[i].GetComponent<RawImage>().texture = books;
                    puzzlesUI[i].GetComponent<UIVariables>().puzzle = "bookcase";
                    puzzlesUI[i].GetComponent<UIVariables>().completed = false;
                    puzzlesUI[i].tag = "BooksIcon";
                    break;
                case "punchreader":
                    puzzlesUI[i].GetComponent<RawImage>().texture = punched;
                    puzzlesUI[i].GetComponent<UIVariables>().puzzle = "punchreader";
                    puzzlesUI[i].GetComponent<UIVariables>().completed = false;
                    puzzlesUI[i].tag = "PunchedIcon";
                    break;
                case "safe":
                    puzzlesUI[i].GetComponent<RawImage>().texture = safe;
                    puzzlesUI[i].GetComponent<UIVariables>().puzzle = "safe";
                    puzzlesUI[i].GetComponent<UIVariables>().completed = false;
                    break;
                case "phone":
                    puzzlesUI[i].GetComponent<RawImage>().texture = phone;
                    puzzlesUI[i].GetComponent<UIVariables>().puzzle = "phone";
                    puzzlesUI[i].GetComponent<UIVariables>().completed = false;
                    break;
            }
        }
    }
}