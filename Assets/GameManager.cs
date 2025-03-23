using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class GameManager : MonoBehaviour
{
    public Player player;
    public int diceSides = 6; // Number of sides on the dice
    

public TextMeshProUGUI diceRollText; // Reference to the TextMeshProUGUI component

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // Press Space to roll the dice
        {
            int steps = RollDice();
            diceRollText.text = $"You rolled a {steps}!"; // Update the text to show the dice roll
            Debug.Log($"You rolled a {steps}!");

            player.MovePlayer(steps);
        }
    }

    private int RollDice()
    {
        return Random.Range(1, diceSides +1);
    }
}

