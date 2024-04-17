using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float moveSpeed = 5f; // Speed of the character movement
    public float sprintSpeed = 10f; // Speed of the character when sprinting
    public float sprintDuration = 5f; // Duration of sprinting
    public float sprintCooldown = 2.5f; // Cooldown period for sprinting
    private bool isSprinting = false; // Flag to track if the character is currently sprinting
    private float sprintTimer = 0f; // Timer for sprinting
    private bool canSprint = true; // Flag to track if the character can sprint

    void Update()
    {
        // Input for horizontal and vertical movement
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Check if the character can sprint
        if (canSprint && Input.GetKey(KeyCode.LeftShift))
        {
            isSprinting = true; // Start sprinting
            sprintTimer += Time.deltaTime; // Increment sprint timer
            if (sprintTimer >= sprintDuration)
            {
                sprintTimer = 0f; // Reset sprint timer
                isSprinting = false; // Stop sprinting
                canSprint = false; // Disable sprinting
                StartCoroutine(SprintCooldown()); // Start sprint cooldown
            }
        }
        else
        {
            isSprinting = false; // Stop sprinting if sprint key is released
        }

        // Calculate movement direction and speed based on sprinting state
        Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical);
        float speed = isSprinting ? sprintSpeed : moveSpeed;
        movement *= speed * Time.deltaTime;

        // Move the character
        transform.Translate(movement);
    }

    IEnumerator SprintCooldown()
    {
        yield return new WaitForSeconds(sprintCooldown);
        canSprint = true; // Enable sprinting after cooldown period
    }
}