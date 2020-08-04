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

    public void LoadPuzzles()
    {
        puzzles.Add("wirebox");
        puzzles.Add("cards");
        puzzles.Add("bookcase");
        puzzles.Add("punchreader");
    }
    
    void ShufflePuzzles<T>(List<T> puzzlesList)
    {
        System.Random random = new System.Random();
        int n = puzzlesList.Count;
        while (n>1)
        {
            int k = random.Next(n);
            n--;
            T temp = puzzlesList[k];
            puzzlesList[k] = puzzlesList[n];
            puzzlesList[n] = temp;
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
            }
        }
    }
}