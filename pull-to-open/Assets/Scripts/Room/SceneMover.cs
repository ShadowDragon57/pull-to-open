using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneMover : MonoBehaviour
{
    // Start is called before the first frame update


    public void StartWiresPuzzle()
    {
        SceneManager.LoadScene("Puzzle 1 - Wires");

    }
    public void StartPlayingCardsPuzzle()
    {
        SceneManager.LoadScene("Puzzle 2 - Playing Cards");

    }

    public void StartBookcasePuzzle()
    {
        SceneManager.LoadScene("Puzzle 3 - Bookcase");

    }

    public void StartPunchedPuzzle()
    {
        SceneManager.LoadScene("Puzzle 4 - Punched Card");

    }

    public void StartSafePuzzle()
    {
        SceneManager.LoadScene("Puzzle 5 - Safe");

    }

    public void StartPhonePuzzle()
    {
        SceneManager.LoadScene("Puzzle 6 - Rotary Phone");
 
    }

    public void ReturnToRoom()
    {
        SceneManager.LoadScene("Room");
    }
}
