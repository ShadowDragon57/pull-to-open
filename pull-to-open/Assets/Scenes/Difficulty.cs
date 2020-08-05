using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Difficulty : MonoBehaviour
{
    public List<string> puzzles = new List<string>();

    public GameObject WirePuzzle;
    public GameObject BookcasePuzzle;
    public GameObject CardsPuzzle;
    public GameObject PunchedPuzzle;
    public GameObject SafePuzzle;
    public GameObject PhonePuzzle;

    public void LoadPuzzles()
    {
        puzzles.Add("wirebox");
        puzzles.Add("cards");
        puzzles.Add("bookcase");
        puzzles.Add("punchreader");
        puzzles.Add("safe");
        puzzles.Add("phone");
    }
    
    void ShufflePuzzles<T>(List<T> puzzlesList)
    {
        System.Random random = new System.Random();
        
        for (int i=0; i<6; i++)
        {
            int j = random.Next(i+1);
            var temp = puzzlesList[i];
            puzzlesList[i] = puzzlesList[j];
            puzzlesList[j] = temp;
        }

        for (int i=0; i<6; i++)
        {
            Debug.Log(puzzles[i]);
        }
    }
    
    public void easyDiff()
    {
        LoadPuzzles();
        ShufflePuzzles(puzzles);
        spawnPuzzles(2, puzzles);
    }

    public void mediumDiff()
    {
        LoadPuzzles();
        ShufflePuzzles(puzzles);
        spawnPuzzles(4, puzzles);
    }

    public void hardDiff()
    {
        LoadPuzzles();
        ShufflePuzzles(puzzles);
        spawnPuzzles(6, puzzles);
    }

    public void spawnPuzzles(int diff, List<string> puzzles)
    {
        WirePuzzle.SetActive(false);
        CardsPuzzle.SetActive(false);
        BookcasePuzzle.SetActive(false);
        PunchedPuzzle.SetActive(false);
        SafePuzzle.SetActive(false);
        PhonePuzzle.SetActive(false);

        for (int i = 0; i < diff; i++)
        {
            switch (puzzles[i])
            {
                case "wirebox":
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
            Debug.Log(puzzles[i]);
        }
    }
}