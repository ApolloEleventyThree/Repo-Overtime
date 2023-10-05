using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Adjust this value to control the movement speed.

    void Update()
    {
        // Get input from the arrow keys or WASD keys.
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate the movement direction.
        Vector3 moveDirection = new Vector3(horizontalInput, 0f, verticalInput).normalized;

        // If there is input, move the player.
        if (moveDirection != Vector3.zero)
        {
            // Calculate the new position.
            Vector3 newPosition = transform.position + moveDirection * moveSpeed * Time.deltaTime;

            // Move the player to the new position.
            transform.position = newPosition;
        }
    }
}