using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class GameManager : MonoBehaviour
{
    public int diceSides = 3; // Number of sides on the dice
    public TextMeshProUGUI diceRollText;
    public TextMeshProUGUI currentplayertext; // Reference to the TextMeshProUGUI component

    public int currentPlayer = 0; // 0 for player 1, 1 for player 2
    public Player[] players = new Player[4];
     public CameraFollow cameraFollow;

    private void Start()
    {
        Debug.Log("Current player: " + players[currentPlayer].name);
        startTurn();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // Press Space to roll the dice
        {
            int steps = RollDice();
            diceRollText.text = $"You spun a {steps}!"; // Update the text to show the dice roll
            Debug.Log($"You spun a {steps}!");
            currentplayertext.text = $"Current player: {players[currentPlayer].name}";

            players[currentPlayer].MovePlayer(steps); // Call MovePlayer on the current player
            endTurn();
        }

        //if (Input.GetKeyDown(KeyCode.Return)) // Press Enter to switch to the next player
       // {
           // currentPlayer = (currentPlayer + 1) % players.Length;
           // Debug.Log("Current player: " + players[currentPlayer].name);
       // }
    }

    private int RollDice()
    {
        return Random.Range(1, diceSides +1);
    }
    private void startTurn()
    {
        Debug.Log("Player's turn"+ players[currentPlayer].name);
        cameraFollow.target = players[currentPlayerIndex].transform; 
    }
    private int endTurn()
    {
        Debug.Log("End of player's turn"+ players[currentPlayer].name);
        currentPlayer = (currentPlayer + 1) % players.Length;
        startTurn();
        return 0;
    }

}

