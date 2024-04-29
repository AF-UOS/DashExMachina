using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour

{
    public float speed = 5f; // Regular movement speed
    public float sprintSpeed = 10f; // Speed when sprinting
    public float sprintDuration = 2.5f; // Duration of sprint in seconds
    public float sprintCooldown = 3f; // Cooldown period for sprint in seconds
    public float jumpForce = 7f; // Force applied when jumping
    public float gravity = 20f; // Gravity force

    private CharacterController characterController;
    private Vector3 moveDirection;
    private bool isSprinting = false;
    private float sprintTimer = 0f;
    private float cooldownTimer = 0f;
    float camera;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        camera += Input.GetAxis("Mouse X");
        // Check if the player is grounded
        if (characterController.isGrounded)
        {
            // Calculate movement direction based on player input
            float horizontalInput = Input.GetAxis("Horizontal");
            float verticalInput = Input.GetAxis("Vertical");
            moveDirection = transform.TransformDirection(new Vector3((horizontalInput * Mathf.Cos(camera)) + (verticalInput * Mathf.Sin(camera)), 0f, (verticalInput * Mathf.Sin(camera)) + (horizontalInput * Mathf.Cos(camera))));

            // Apply speed based on whether sprinting or not
            float currentSpeed = isSprinting ? sprintSpeed : speed;
            moveDirection *= currentSpeed;

            // Check for jump input
            if (Input.GetKeyDown(KeyCode.Space))
            {
                moveDirection.y = jumpForce;
            }

            // Manage sprinting
            if (Input.GetKey(KeyCode.LeftShift) && !isSprinting && cooldownTimer <= 0f)
            {
                StartSprint();
            }
            else if (isSprinting && (sprintTimer >= sprintDuration || Input.GetKeyUp(KeyCode.LeftShift)))
            {
                StopSprint();
            }
        }

        // Apply gravity to the movement direction
        moveDirection.y -= gravity * Time.deltaTime;

        // Move the character controller
        characterController.Move(moveDirection * Time.deltaTime);

        // Update sprint and cooldown timers
        if (isSprinting)
        {
            sprintTimer += Time.deltaTime;
            if (sprintTimer >= sprintDuration)
            {
                StopSprint();
            }
        }
        else if (cooldownTimer > 0f)
        {
            cooldownTimer -= Time.deltaTime;
        }
    }

    void StartSprint()
    {
        isSprinting = true;
        sprintTimer = 0f;
    }

    void StopSprint()
    {
        isSprinting = false;
        cooldownTimer = sprintCooldown - sprintTimer;
        sprintTimer = 0f;
    }
}
