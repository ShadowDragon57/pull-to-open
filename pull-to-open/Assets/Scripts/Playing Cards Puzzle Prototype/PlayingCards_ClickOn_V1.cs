using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.Assertions.Must;
using UnityEngine.Jobs;
using UnityEngine.UI;

public class PlayingCards_ClickOn_V1 : MonoBehaviour
{
    [SerializeField]
    private GameObject[] aceOfClubs = new GameObject[9]; //arrays for the prefabs to be put in, named according to 
    [SerializeField]                                     //the first card in the column.
    private GameObject[] twoOfSpades = new GameObject[9];
    [SerializeField]
    private GameObject[] nineOfSpades = new GameObject[9];
    [SerializeField]
    private GameObject[] tenOfClubs = new GameObject[9];
    [SerializeField]
    private GameObject[] aceOfDiamonds = new GameObject[9];
    [SerializeField]
    private GameObject[] kingOfClubs = new GameObject[9];

    [SerializeField]
    private Transform[] emptyCardTansforms = new Transform[5]; //array to use the cards as transforms
    [SerializeField]
    private GameObject[] cardObjects = new GameObject[5]; // array to use the cards as gameobjects

    private string pickedColumn; //string for the column that was randomly picked

    private static int[] rndArr = new int[5]; //array of random ints
    private int[] sortedRndArr = new int[5]; //array of sorted random ints

    private int rnd; //random int
    private int tempInt;

    void Start()
    {

        PickColumn(); //method to pick a random column for the cards to picked from
        if (pickedColumn == "null") //defensive coding
        {
            Start();
        }
        print(pickedColumn); //testing purposes

        GenerateFiveCards(pickedColumn); //method to pick the 5 cards from the picked column

        AssignCardTags(); //method to assign the tags to the cards, respective to what order the player needs
                          //to click them in
    }

    void AssignCardTags() //method to assign the tags to the cards, respective to what order the player needs
    {                     //to click them in
        for(int i = 0; i <= 4; i++)
        {
            sortedRndArr[i] = rndArr[i];
        }

        System.Array.Sort(sortedRndArr); //sorting the array from lowest to highest

        tempInt = sortedRndArr[0]; //finding the lowest number

        for(int i = 0; i <= 4; i++)
        {
            if(tempInt == rndArr[i])
            {
                cardObjects[i].tag = "Card1";
            }
        }

        tempInt = sortedRndArr[1]; //other 3 are finding the ones in between the highest and lowest

        for (int i = 0; i <= 4; i++)
        {
            if (tempInt == rndArr[i])
            {
                cardObjects[i].tag = "Card2";
            }
        }

        tempInt = sortedRndArr[2]; 

        for (int i = 0; i <= 4; i++)
        {
            if (tempInt == rndArr[i])
            {
                cardObjects[i].tag = "Card3";
            }
        }

        tempInt = sortedRndArr[3]; 

        for (int i = 0; i <= 4; i++)
        {
            if (tempInt == rndArr[i])
            {
                cardObjects[i].tag = "Card4";
            }
        }

        tempInt = sortedRndArr[4]; //finding the highest number

        for (int i = 0; i <= 4; i++)
        {
            if (tempInt == rndArr[i])
            {
                cardObjects[i].tag = "Card5";
            }
        }
    }

    string PickColumn() //method to pick a random column for the cards to picked from
    {
        rnd = UnityEngine.Random.Range(0, 7);
        switch (rnd) //picking a column of cards to use for the puzzle
        {
            case 1:
                pickedColumn = "aceOfClubs";
                break;
            case 2:
                pickedColumn = "twoOfSpades";
                break;
            case 3:
                pickedColumn = "nineOfSpades";
                break;
            case 4:
                pickedColumn = "tenOfClubs";
                break;
            case 5:
                pickedColumn = "aceOfDiamonds";
                break;
            case 6:
                pickedColumn = "kingOfClubs";
                break;
            default:
                pickedColumn = "null";
                break;
        }
        return pickedColumn;
    }

    void GenerateFiveCards(string pickedColumn) //method to pick the 5 cards from the picked column
    {
        switch(pickedColumn)
        {
            case "aceOfClubs":
                rndArr[0] = UnityEngine.Random.Range(0, 9);
                Instantiate(aceOfClubs[rndArr[0]], emptyCardTansforms[0].position, Quaternion.identity);

                do
                {
                    rndArr[1] = UnityEngine.Random.Range(0, 9);
                } while (rndArr[1] == rndArr[0]);
                Instantiate(aceOfClubs[rndArr[1]], emptyCardTansforms[1].position, Quaternion.identity);

                do
                {
                    rndArr[2] = UnityEngine.Random.Range(0, 9);
                } while (rndArr[2] == rndArr[1] || rndArr[2] == rndArr[0]);
                Instantiate(aceOfClubs[rndArr[2]], emptyCardTansforms[2].position, Quaternion.identity);

                do
                {
                    rndArr[3] = UnityEngine.Random.Range(0, 9);
                } while (rndArr[3] == rndArr[2] || rndArr[3] == rndArr[1] || rndArr[3] == rndArr[0]);
                Instantiate(aceOfClubs[rndArr[3]], emptyCardTansforms[3].position, Quaternion.identity);

                do
                {
                    rndArr[4] = UnityEngine.Random.Range(0, 9);
                } while (rndArr[4] == rndArr[3] || rndArr[4] == rndArr[2] || rndArr[4] == rndArr[1] || rndArr[4] == rndArr[0]);
                Instantiate(aceOfClubs[rndArr[4]], emptyCardTansforms[4].position, Quaternion.identity);

                break;

            case "twoOfSpades":
                rndArr[0] = UnityEngine.Random.Range(0, 9);
                Instantiate(twoOfSpades[rndArr[0]], emptyCardTansforms[0].position, Quaternion.identity);

                do
                {
                    rndArr[1] = UnityEngine.Random.Range(0, 9);
                } while (rndArr[1] == rndArr[0]);
                Instantiate(twoOfSpades[rndArr[1]], emptyCardTansforms[1].position, Quaternion.identity);

                do
                {
                    rndArr[2] = UnityEngine.Random.Range(0, 9);
                } while (rndArr[2] == rndArr[1] || rndArr[2] == rndArr[0]);
                Instantiate(twoOfSpades[rndArr[2]], emptyCardTansforms[2].position, Quaternion.identity);

                do
                {
                    rndArr[3] = UnityEngine.Random.Range(0, 9);
                } while (rndArr[3] == rndArr[2] || rndArr[3] == rndArr[1] || rndArr[3] == rndArr[0]);
                Instantiate(twoOfSpades[rndArr[3]], emptyCardTansforms[3].position, Quaternion.identity);

                do
                {
                    rndArr[4] = UnityEngine.Random.Range(0, 9);
                } while (rndArr[4] == rndArr[3] || rndArr[4] == rndArr[2] || rndArr[4] == rndArr[1] || rndArr[4] == rndArr[0]);
                Instantiate(twoOfSpades[rndArr[4]], emptyCardTansforms[4].position, Quaternion.identity);

                break;

            case "nineOfSpades":
                rndArr[0] = UnityEngine.Random.Range(0, 9);
                Instantiate(nineOfSpades[rndArr[0]], emptyCardTansforms[0].position, Quaternion.identity);

                do
                {
                    rndArr[1] = UnityEngine.Random.Range(0, 9);
                } while (rndArr[1] == rndArr[0]);
                Instantiate(nineOfSpades[rndArr[1]], emptyCardTansforms[1].position, Quaternion.identity);

                do
                {
                    rndArr[2] = UnityEngine.Random.Range(0, 9);
                } while (rndArr[2] == rndArr[1] || rndArr[2] == rndArr[0]);
                Instantiate(nineOfSpades[rndArr[2]], emptyCardTansforms[2].position, Quaternion.identity);

                do
                {
                    rndArr[3] = UnityEngine.Random.Range(0, 9);
                } while (rndArr[3] == rndArr[2] || rndArr[3] == rndArr[1] || rndArr[3] == rndArr[0]);
                Instantiate(nineOfSpades[rndArr[3]], emptyCardTansforms[3].position, Quaternion.identity);

                do
                {
                    rndArr[4] = UnityEngine.Random.Range(0, 9);
                } while (rndArr[4] == rndArr[3] || rndArr[4] == rndArr[2] || rndArr[4] == rndArr[1] || rndArr[4] == rndArr[0]);
                Instantiate(nineOfSpades[rndArr[4]], emptyCardTansforms[4].position, Quaternion.identity);

                break;

            case "tenOfClubs":
                rndArr[0] = UnityEngine.Random.Range(0, 9);
                Instantiate(tenOfClubs[rndArr[0]], emptyCardTansforms[0].position, Quaternion.identity);

                do
                {
                    rndArr[1] = UnityEngine.Random.Range(0, 9);
                } while (rndArr[1] == rndArr[0]);
                Instantiate(tenOfClubs[rndArr[1]], emptyCardTansforms[1].position, Quaternion.identity);

                do
                {
                    rndArr[2] = UnityEngine.Random.Range(0, 9);
                } while (rndArr[2] == rndArr[1] || rndArr[2] == rndArr[0]);
                Instantiate(tenOfClubs[rndArr[2]], emptyCardTansforms[2].position, Quaternion.identity);

                do
                {
                    rndArr[3] = UnityEngine.Random.Range(0, 9);
                } while (rndArr[3] == rndArr[2] || rndArr[3] == rndArr[1] || rndArr[3] == rndArr[0]);
                Instantiate(tenOfClubs[rndArr[3]], emptyCardTansforms[3].position, Quaternion.identity);

                do
                {
                    rndArr[4] = UnityEngine.Random.Range(0, 9);
                } while (rndArr[4] == rndArr[3] || rndArr[4] == rndArr[2] || rndArr[4] == rndArr[1] || rndArr[4] == rndArr[0]);
                Instantiate(tenOfClubs[rndArr[4]], emptyCardTansforms[4].position, Quaternion.identity);

                break;

            case "aceOfDiamonds":
                rndArr[0] = UnityEngine.Random.Range(0, 9);
                Instantiate(aceOfDiamonds[rndArr[0]], emptyCardTansforms[0].position, Quaternion.identity);

                do
                {
                    rndArr[1] = UnityEngine.Random.Range(0, 9);
                } while (rndArr[1] == rndArr[0]);
                Instantiate(aceOfDiamonds[rndArr[1]], emptyCardTansforms[1].position, Quaternion.identity);

                do
                {
                    rndArr[2] = UnityEngine.Random.Range(0, 9);
                } while (rndArr[2] == rndArr[1] || rndArr[2] == rndArr[0]);
                Instantiate(aceOfDiamonds[rndArr[2]], emptyCardTansforms[2].position, Quaternion.identity);

                do
                {
                    rndArr[3] = UnityEngine.Random.Range(0, 9);
                } while (rndArr[3] == rndArr[2] || rndArr[3] == rndArr[1] || rndArr[3] == rndArr[0]);
                Instantiate(aceOfDiamonds[rndArr[3]], emptyCardTansforms[3].position, Quaternion.identity);

                do
                {
                    rndArr[4] = UnityEngine.Random.Range(0, 9);
                } while (rndArr[4] == rndArr[3] || rndArr[4] == rndArr[2] || rndArr[4] == rndArr[1] || rndArr[4] == rndArr[0]);
                Instantiate(aceOfDiamonds[rndArr[4]], emptyCardTansforms[4].position, Quaternion.identity);

                break;

            case "kingOfClubs":
                rndArr[0] = UnityEngine.Random.Range(0, 9);
                Instantiate(kingOfClubs[rndArr[0]], emptyCardTansforms[0].position, Quaternion.identity);

                do
                {
                    rndArr[1] = UnityEngine.Random.Range(0, 9);
                } while (rndArr[1] == rndArr[0]);
                Instantiate(kingOfClubs[rndArr[1]], emptyCardTansforms[1].position, Quaternion.identity);

                do
                {
                    rndArr[2] = UnityEngine.Random.Range(0, 9);
                } while (rndArr[2] == rndArr[1] || rndArr[2] == rndArr[0]);
                Instantiate(kingOfClubs[rndArr[2]], emptyCardTansforms[2].position, Quaternion.identity);

                do
                {
                    rndArr[3] = UnityEngine.Random.Range(0, 9);
                } while (rndArr[3] == rndArr[2] || rndArr[3] == rndArr[1] || rndArr[3] == rndArr[0]);
                Instantiate(kingOfClubs[rndArr[3]], emptyCardTansforms[3].position, Quaternion.identity);

                do
                {
                    rndArr[4] = UnityEngine.Random.Range(0, 9);
                } while (rndArr[4] == rndArr[3] || rndArr[4] == rndArr[2] || rndArr[4] == rndArr[1] || rndArr[4] == rndArr[0]);
                Instantiate(kingOfClubs[rndArr[4]], emptyCardTansforms[4].position, Quaternion.identity);

                break;
        }
    }
}
