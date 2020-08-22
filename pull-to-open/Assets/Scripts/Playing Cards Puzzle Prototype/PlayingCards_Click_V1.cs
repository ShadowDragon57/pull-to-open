using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayingCards_Click_V1 : MonoBehaviour
{
    [SerializeField]
    private LayerMask clickablesLayer;

    [SerializeField]
    private Text counter; //display to show the player if they are clicking the cards in the correct order.

    [SerializeField]
    private GameObject winText;

    GameObject clickedCard;

    public int rightOrderCounter;


    void Start()
    {
        winText.SetActive(false);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            RaycastHit rayHit; 

            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out rayHit, Mathf.Infinity, clickablesLayer))
            {
                clickedCard = rayHit.collider.gameObject; //gets the clicked on object as a gameobject
                if(clickedCard.CompareTag("Card1")) //checks the tag of the clicked on object and sends the script to
                {                                   //the correct method
                    print(clickedCard.tag);
                    Card1Click();
                }
                else if (clickedCard.CompareTag("Card2"))
                {
                    print(clickedCard.tag);
                    Card2Click();
                }
                else if (clickedCard.CompareTag("Card3"))
                {
                    print(clickedCard.tag);
                    Card3Click();
                }
                else if (clickedCard.CompareTag("Card4"))
                {
                    print(clickedCard.tag);
                    Card4Click();
                }
                else if (clickedCard.CompareTag("Card5"))
                {
                    print(clickedCard.tag);
                    Card5Click();
                }
            }
        }
    }

    void Card1Click() //method that controls what happens when the first card is clicked on.
    {
        if (rightOrderCounter > 1)
        {
            rightOrderCounter = 0;
            counter.text = rightOrderCounter.ToString();
        }
        else if (rightOrderCounter == 0)
        {
            rightOrderCounter = 1;
            counter.text = rightOrderCounter.ToString();
        }
    }

    void Card2Click() //method that controls what happens when the second card is clicked on.
    {
        if (rightOrderCounter > 2)
        {
            rightOrderCounter = 0;
            counter.text = rightOrderCounter.ToString();
        }
        else if (rightOrderCounter == 1)
        {
            rightOrderCounter = 2;
            counter.text = rightOrderCounter.ToString();
        }
    }
    void Card3Click() //method that controls what happens when the third card is clicked on.
    {
        if (rightOrderCounter > 3)
        {
            rightOrderCounter = 0;
            counter.text = rightOrderCounter.ToString();
        }
        else if (rightOrderCounter == 2)
        {
            rightOrderCounter = 3;
            counter.text = rightOrderCounter.ToString();
        }
        else if (rightOrderCounter < 2)
        {
            rightOrderCounter = 0;
            counter.text = rightOrderCounter.ToString();
        }
    }
    void Card4Click() //method that controls what happens when the fourth card is clicked on.
    {
        if (rightOrderCounter > 4)
        {
            rightOrderCounter = 0;
            counter.text = rightOrderCounter.ToString();
        }
        else if (rightOrderCounter == 3)
        {
            rightOrderCounter = 4;
            counter.text = rightOrderCounter.ToString();
        }
        else if(rightOrderCounter < 3)
        {
            rightOrderCounter = 0;
            counter.text = rightOrderCounter.ToString();
        }
    }
    void Card5Click() //method that controls what happens when the fifth card is clicked on.
    {
        if (rightOrderCounter == 4) //this is the parameter to win 
        {
            rightOrderCounter = 5;
            counter.text = rightOrderCounter.ToString();
            winText.SetActive(true);
        }
        else if(rightOrderCounter < 4)
        {
            rightOrderCounter = 0;
            counter.text = rightOrderCounter.ToString();
        }
    }
}
