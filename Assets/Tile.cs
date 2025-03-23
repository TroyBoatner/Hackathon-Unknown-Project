using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public int tileID; // Unique ID for each tile
    public string tileEffect; // Effect when player lands on this tile

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log($"Player landed on Tile {tileID}: {tileEffect}");
            ApplyEffect(other.gameObject);
        }
    }

    private void ApplyEffect(GameObject playerObject)
    {
        Player player = playerObject.GetComponent<Player>();
        if (player != null)
        {
            switch (tileEffect)
            {
                case "GainMoney":
                    player.AddMoney(100);
                    break;
                case "LoseMoney":
                    player.DeductMoney(50);
                    break;
                case "Teleport":
                    player.TeleportToStart();
                    break;
                default:
                    Debug.Log("No effect applied.");
                    break;
            }
        }
        else
        {
            Debug.LogError("Player component not found on the player object!");
        }
    }
}