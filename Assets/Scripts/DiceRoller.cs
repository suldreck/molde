using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiceRoller : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        DiceValues = new int[1];
        theStateManager = GameObject.FindObjectOfType<StateManager>();
    }

    StateManager theStateManager;

    public int[] DiceValues;

    public Sprite[] DiceImageOne;
    public Sprite[] DiceImageZero;


    // Update is called once per frame
    void Update()
    {
		
    }

    public void RollTheDice()
    {

        if (theStateManager.IsDoneRolling == true)
        {
            // We've already rolled this turn.
            return;
        }

        // In Ur, you roll four dice (classically Tetrahedron), which
        // have half their faces have a value of "1" and half have a value
        // of zero.

        // You COULD roll actual physics enabled dice.

        // We are going to use random number generation instead.

        theStateManager.DiceTotal = 3;
        //theStateManager.DiceTotal +=Random.Range(1, 6);
        if (theStateManager.penal[theStateManager.CurrentPlayerId] > 0)
        {
            theStateManager.penal[theStateManager.CurrentPlayerId]--;
            theStateManager.NewTurn();
        }
        else
        {

        theStateManager.IsDoneRolling = true;
        } 
       // theStateManager.CheckLegalMoves();


        //Debug.Log("Rolled: " + DiceTotal);
    }
}
