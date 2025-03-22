using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TurnManager : MonoBehaviour
{
    public int currentPlayer = 0; 
    public Player[] players = new Player[4];

    public TextMeshProUGUI turnText; 

    void Start()
    {
        for (int i = 0; i < players.Length; i++)
        {
            players[i] = new Player();
        }
    }

    void Update()
    {
        
    }

    public void doTurn () {
        Debug.Log("Doing turn for " + currentPlayer);

        Player player = players[currentPlayer];

        player.Talk();


        Debug.Log("Money for player : " + player.Money);
        player.Money = 3;
        Debug.Log("Money for player : " + player.Money);

        advanceTurn();

    }

    public void advanceTurn () {
        currentPlayer  = (currentPlayer + 1) % players.Length;

        // Update text on screen
        turnText.text = "Player: " + currentPlayer;
    }

}
