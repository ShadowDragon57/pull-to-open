using Packages.Rider.Editor;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Wires_ClickOn_Final_Prototype : MonoBehaviour
{
    [SerializeField] //Serializing the field makes the variable private, yet still accessable by Unity.
    private Material invisible;
    [SerializeField]
    private GameObject redLight;
    [SerializeField]
    private GameObject[] allWires = new GameObject[3]; //An array for all the wires in the puzzle to be put in.
    [SerializeField]
    private Material[] colours = new Material[5]; //An array for colours

    private GameObject solutionWire;
   
    private List<GameObject> blueWires = new List<GameObject>(); //List of blue wires currently in the game, assigned by script.
    private List<int> solutions = new List<int>(); //List of possible solutions for it to randomly choose from later.

    public int rndPickedSolution;

    private MeshRenderer meshTemp;

    private Material colour;

    public int test;

    void Start()
    {
        //Adding all of the solutions to the list.
        solutions.Add(1); //No blue wires
        solutions.Add(2); //Last wire white
        solutions.Add(3); //More than one blue wire
        solutions.Add(4); //Otherwise

        rndPickedSolution = solutions[Random.Range(0, solutions.Count)]; //Picking a random solution
        AssignTagsAndColours(rndPickedSolution); //Calling a method to assign tags and colours and sending the picked-
                                                 //-solution to it.                                                 
        foreach (GameObject wire in allWires) //Checking for blue wires and adding them to the blueWire list.
        {
            if (wire.CompareTag("BlueWire"))
            {
                blueWires.Add(wire);
            }
        }

        AssignSolutionWire(rndPickedSolution); //Calling a method to assign a SolutionWire and sending the picked solution-
                                               //-to it.     
        redLight.SetActive(true); //Ensuring the light stays red at the start, purely defensive coding.
    }
    void AssignTagsAndColours(int picked) //This method assigns the tags and colours of wires according to the defuser manual- 
                                          //-and a bit of randomness.
    {
        test = picked;
        if (picked == 1)
        {
            foreach (GameObject wire in allWires)
            {
                colour = colours[Random.Range(0, colours.Length - 1)]; //Picking a random colour, however-
                                                                       //-excludes the blue material.
                meshTemp = wire.GetComponent<MeshRenderer>(); //Assigning the temporary mesh to the particular wire.
                meshTemp.material = colour; //Giving it the colour.               
            }
        }
        else if (picked == 2)
        {
            foreach (GameObject wire in allWires)
            {
                colour = colours[Random.Range(0, (colours.Length))]; 
                meshTemp = wire.GetComponent<MeshRenderer>();
                meshTemp.material = colour;              
            }
            colour = colours[0];
            meshTemp = allWires[2].GetComponent<MeshRenderer>();
            meshTemp.material = colour; //Making the last one always white.
            foreach (GameObject wire in allWires)
            {
                meshTemp = wire.GetComponent<MeshRenderer>();
                if (meshTemp.material.name == "blue (Instance)")
                {
                    wire.tag = "BlueWire"; //Changing all wires that are blue to have the bluewire tag for listing purposes.
                }
            }
        }
        else if (picked == 3)
        {
            foreach (GameObject wire in allWires)
            {
                colour = colours[4]; //Making all of the wires blue.
                meshTemp = wire.GetComponent<MeshRenderer>();
                meshTemp.material = colour;
            }
            colour = colours[Random.Range(0, (colours.Length))];
            meshTemp = allWires[Random.Range(0, allWires.Length)].GetComponent<MeshRenderer>(); //Changing a random wire-
            meshTemp.material = colour;                                                         //-to a different colour-
                                                                                                //-including blue.  
            colour = colours[Random.Range(1, colours.Length - 1)];
            meshTemp = allWires[2].GetComponent<MeshRenderer>();
            meshTemp.material = colour; //Making sure the last wire is never white.
            
            foreach (GameObject wire in allWires)
            {
                meshTemp = wire.GetComponent<MeshRenderer>();
                if (meshTemp.material.name == "blue (Instance)")
                {
                    wire.tag = "BlueWire";
                }
            }
        }
        else if (picked == 4)
        {
            colour = colours[Random.Range(0, (colours.Length - 1))]; //Assigning a random colour to the first wire-
            meshTemp = allWires[0].GetComponent<MeshRenderer>();     //-excluding blue.
            meshTemp.material = colour;

            colour = colours[4];
            meshTemp = allWires[1].GetComponent<MeshRenderer>();
            meshTemp.material = colour; //Guaranteeing there is at least one blue wire, but no more than 1.

            colour = colours[Random.Range(1, colours.Length - 1)];
            meshTemp = allWires[2].GetComponent<MeshRenderer>();
            meshTemp.material = colour; //Making sure the last wire is never white.

            foreach (GameObject wire in allWires)
            {
                meshTemp = wire.GetComponent<MeshRenderer>();
                if (meshTemp.material.name == "blue (Instance)")
                {
                    wire.tag = "BlueWire";
                }
            }
        }
    }

    void AssignSolutionWire(int picked) //This methods figures out which solution was picked and assigns one of the-
                                        //-wires to be the SolutionWire according to the defuser manual.
    {
        if (picked == 1)
        {
            solutionWire = allWires[1];
            solutionWire.name = "SolutionWire";
        }
        else if (picked == 2)
        {
            solutionWire = allWires[2];
            solutionWire.name = "SolutionWire";
        }
        else if (picked == 3)
        {
            solutionWire = blueWires.Last<GameObject>();
            solutionWire.name = "SolutionWire";
        }
        else if (picked == 4)
        {
            solutionWire = allWires[2];
            solutionWire.name = "SolutionWire";
        }
    }

    public void WinClick(MeshRenderer wireRend)
    {
        wireRend.material = invisible;
        redLight.SetActive(false);
    }

    public void ClickMe(MeshRenderer wireRend)
    {
        wireRend.material = invisible; //Turns whatever has been clicked invisible.
    }
}
