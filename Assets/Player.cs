using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    public int money = 1000; // Starting money
    public int currentTileIndex = 0; // Current tile position
    public GameObject[] tiles; // Array of all tiles

    public TextMeshProUGUI stopheretext;

    public Occupation job;

    private void Start()
    {
        Debug.Log("Player started at tile 1.");
        tiles = GameObject.FindGameObjectsWithTag("Tiles");
    }

    public void MovePlayer(int steps)
    {
       
        int newtitleIndex = currentTileIndex + steps;
        if (newtitleIndex >= tiles.Length)
        {
            newtitleIndex = tiles.Length - 1;
        }
        for (int i = currentTileIndex + 1; i <= newtitleIndex; i++)
        { 
            currentTileIndex = i;
            transform.position = tiles[i].transform.position + Vector3.up * 0.5f;
            Debug.Log($"Moved to Tile {i + 1}");
           if(tiles[currentTileIndex].CompareTag("Stopherecheckpoint"))
            {
                Debug.Log("Player stopped here.");
                stopheretext.text = $"Stop here";
                StopHere();
                break;
            }
        }
    
    }
    
    private void StopHere()
    {
        Debug.Log("Player stopped here.");
        
    }
    public void AddMoney(int amount)
    {
        money += amount;
         // Update the text to show the money
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

