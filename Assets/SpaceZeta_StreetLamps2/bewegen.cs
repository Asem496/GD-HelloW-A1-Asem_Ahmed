using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bewegen : MonoBehaviour
{
    // Rigidbody as variable
    private Rigidbody rb;

    // Movement speed
    public float speed = 5f;
    public float jumpspeed = 20f;

    // Ground check variables
    private bool isGrounded;
    public float groundCheckDistance = 0.1f;  // Adjust as needed for your model
    public LayerMask groundLayer;  // Assign a ground layer in Unity to check only against the ground

    // Camera variables
    public Transform playerCamera;  // Assign the Camera object in the Inspector
    public float mouseSensitivity = 2f;  // Adjust for desired sensitivity
    private float cameraPitch = 0f;

    // Start is called before the first frame update
    void Start()
    {
        // Get the Rigidbody component
        rb = GetComponent<Rigidbody>();

        // Enable gravity for realistic movement
        rb.useGravity = true;

        // Lock the cursor to the center of the screen
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        // Check if the player is grounded
        isGrounded = Physics.Raycast(transform.position, Vector3.down, groundCheckDistance, groundLayer);

        // Input variables for WASD movement
        float moveHorizontal = 0f;
        float moveVertical = 0f;

        // Check WASD keys for movement on X and Z axes
        if (Input.GetKey(KeyCode.W))
        {
            moveVertical = 1f;  // Forward (Z-axis)
        }
        else if (Input.GetKey(KeyCode.S))
        {
            moveVertical = -1f;  // Backward (Z-axis)
        }

        if (Input.GetKey(KeyCode.A))
        {
            moveHorizontal = -1f;  // Left (X-axis)
        }
        else if (Input.GetKey(KeyCode.D))
        {
            moveHorizontal = 1f;  // Right (X-axis)
        }

        // Jump logic - only jump if player is grounded
        if (Input.GetKey(KeyCode.Space) && isGrounded)
        {
            rb.velocity = new Vector3(rb.velocity.x, jumpspeed, rb.velocity.z);
        }

        // Calculate movement vector relative to the player's orientation
        Vector3 movement = (transform.forward * moveVertical + transform.right * moveHorizontal).normalized * speed;

        // Apply velocity directly to Rigidbody without affecting rotation
        rb.velocity = new Vector3(movement.x, rb.velocity.y, movement.z);

        // Handle camera rotation
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity;

        // Rotate the player horizontally
        transform.Rotate(Vector3.up * mouseX);

        // Adjust camera pitch (vertical rotation)
        cameraPitch -= mouseY;
        cameraPitch = Mathf.Clamp(cameraPitch, -90f, 90f);

        // Apply rotation to the camera
        playerCamera.localRotation = Quaternion.Euler(cameraPitch, 0f, 0f);
    }
}
