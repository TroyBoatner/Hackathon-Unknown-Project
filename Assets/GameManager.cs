using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class GameManager : MonoBehaviour
{
    public int diceSides = 6; // Number of sides on the dice
    public TextMeshProUGUI diceRollText; // Reference to the TextMeshProUGUI component

    public int currentPlayer = 0; // 0 for player 1, 1 for player 2
    public Player[] players = new Player[4];

    private void Start()
    {
        Debug.Log("Current player: " + players[currentPlayer].name);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // Press Space to roll the dice
        {
            int steps = RollDice();
            diceRollText.text = $"You rolled a {steps}!"; // Update the text to show the dice roll
            Debug.Log($"You rolled a {steps}!");

            players[currentPlayer].MovePlayer(steps); // Call MovePlayer on the current player
        }

        if (Input.GetKeyDown(KeyCode.Return)) // Press Enter to switch to the next player
        {
            currentPlayer = (currentPlayer + 1) % players.Length;
            Debug.Log("Current player: " + players[currentPlayer].name);
        }
    }

    private int RollDice()
    {
        return Random.Range(1, diceSides +1);
    }

}

