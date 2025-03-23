using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Movement speed

    void Update()
    {
        // Get the input from WASD keys (or arrow keys)
        float horizontal = Input.GetAxis("Horizontal"); // A/D or Left/Right Arrow
        float vertical = Input.GetAxis("Vertical"); // W/S or Up/Down Arrow

        // Calculate movement direction
        Vector3 movement = new Vector3(horizontal, 0f, vertical);

        // Apply the movement to the cube
        transform.Translate(movement * moveSpeed * Time.deltaTime);
    }
}
