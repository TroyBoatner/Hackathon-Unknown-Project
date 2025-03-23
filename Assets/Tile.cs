using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Tile : MonoBehaviour
{
    public int tileID; // Unique ID for each tile
    public string tileEffect; // Effect when player lands on this tile
    public TextMeshProUGUI moneychangetext;

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
                    GainMoney(player);
                    break;
                case "LoseMoney":
                    LoseMoney(player);
                    break;
                case "Teleport":
                    Teleport(player);
                    break;
                
                case "Payday":
                    Payday(player);
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

    private void GainMoney(Player player)
    {
        player.AddMoney(100);
        moneychangetext.text = $"You got $100! Total amount of Money: {player.money}";
        moneychangetext.ForceMeshUpdate();
        Debug.Log("Text updated: 100 dollar added!");
    }

    private void LoseMoney(Player player)
    {
        player.DeductMoney(50);
        moneychangetext.text = $"You lost $50! Total amount of Money: {player.money}";
        moneychangetext.ForceMeshUpdate();
        Debug.Log("Text updated: 50 dollar subtracted!");
    }

    private void Teleport(Player player)
    {
        player.TeleportToStart();
    }

    //private void StopHere(Player player)
    //{
      //  Debug.Log("Player stopped here.");
        
    //}

    private void Payday(Player player)
    {
        player.AddMoney(200);
        moneychangetext.text = $"You got $200! Total amount of Money: {player.money}";
        moneychangetext.ForceMeshUpdate();
        Debug.Log("Text updated: 200 dollar added!");
    }
}