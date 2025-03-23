using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int money = 1000; // Starting money
    public int currentTileIndex = 0; // Current tile position
    public GameObject[] tiles; // Array of all tiles

    public void MovePlayer(int steps)
    {
        currentTileIndex = (currentTileIndex + steps) % tiles.Length;
        transform.position = tiles[currentTileIndex].transform.position + Vector3.up * 0.5f; // Move player to tile position
        Debug.Log($"Moved to Tile {currentTileIndex + 1}");
    }

    public void AddMoney(int amount)
    {
        money += amount;
        Debug.Log($"Gained ${amount}. Total money: ${money}");
    }

    public void DeductMoney(int amount)
    {
        money -= amount;
        Debug.Log($"Lost ${amount}. Total money: ${money}");
    }

    public void TeleportToStart()
    {
        currentTileIndex = 0;
        transform.position = tiles[currentTileIndex].transform.position + Vector3.up * 0.5f;
        Debug.Log("Teleported to the starting tile.");
    }
}

