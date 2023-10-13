using UnityEngine;

public class UIMovement : MonoBehaviour
{
    public float moveSpeed = 10f; // Adjust this to control the movement speed.
    public RectTransform uiObject; // Reference to the UI GameObject you want to move.

    private void Update()
    {
        // Get the current position of the UI GameObject.
        Vector3 currentPosition = uiObject.anchoredPosition;

        // Check for input to move the UI GameObject.
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate the new position based on input and movement speed.
        Vector3 movement = new Vector3(horizontalInput, verticalInput, 0) * moveSpeed * Time.deltaTime;
        currentPosition += movement;

        // Update the UI GameObject's position.
        uiObject.anchoredPosition = currentPosition;
    }
}
