using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour

{
    //public float speed = 15f; // Regular movement speed
    //public float sprintSpeed = 10f; // Speed when sprinting
    //public float sprintDuration = 2.5f; // Duration of sprint in seconds
    //public float sprintCooldown = 3f; // Cooldown period for sprint in seconds
    public float jumpForce = 3f; // Force applied when jumping
    public float gravity = 60f; // Gravity force

    private CharacterController characterController;
    private Vector3 moveDirection;
    //private bool isSprinting = false;
    //private float sprintTimer = 0f;
    //private float cooldownTimer = 0f;
    static float camera;
    private ValueHandler script;
    int room;
    string roomName;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
        camera = 0;
        GameObject go = GameObject.Find("GameObject");
        script = go.GetComponent<ValueHandler>();
    }

    void Update()
    {
        camera += Input.GetAxis("Mouse X") * 2;
        // Check if the player is grounded
        if (characterController.isGrounded)
        {
            // Calculate movement direction based on player input
            float horizontalInput = Input.GetAxis("Horizontal");
            float verticalInput = Input.GetAxis("Vertical");
            moveDirection = transform.TransformDirection(new Vector3((horizontalInput * Mathf.Cos(-camera * (Mathf.PI / 180))) + (verticalInput * Mathf.Sin(camera * (Mathf.PI / 180))), 0f, (verticalInput * Mathf.Cos(camera * (Mathf.PI / 180))) + (horizontalInput * Mathf.Sin(-camera * (Mathf.PI / 180)))));

            // Apply speed based on whether sprinting or not
            //float currentSpeed = isSprinting ? sprintSpeed : speed;
            moveDirection *= 20f;

            // Check for jump input
            if (Input.GetKeyDown(KeyCode.Space))
            {
                moveDirection.y = jumpForce;
            }

            // Manage sprinting
            //if (Input.GetKey(KeyCode.LeftShift) && !isSprinting && cooldownTimer <= 0f)
            //{
                //StartSprint();
            //}
            //else if (isSprinting && (sprintTimer >= sprintDuration || Input.GetKeyUp(KeyCode.LeftShift)))
            //{
                //StopSprint();
            //}
        }

        // Apply gravity to the movement direction
        moveDirection.y -= gravity * Time.deltaTime;

        // Move the character controller
        characterController.Move(moveDirection * Time.deltaTime);

        // Update sprint and cooldown timers
        //if (isSprinting)
        //{
        //sprintTimer += Time.deltaTime;
        //if (sprintTimer >= sprintDuration)
        //{
        //StopSprint();
        //}
        //}
        //else if (cooldownTimer > 0f)
        //{
        //cooldownTimer -= Time.deltaTime;
        //}
        if (Input.GetKey(KeyCode.R)) 
        {
            script.active = 1;
        }
    }

    //void StartSprint()
    //{
        //isSprinting = true;
        //sprintTimer = 0f;
    //}

    //void StopSprint()
    //{
        //isSprinting = false;
        //cooldownTimer = sprintCooldown - sprintTimer;
        //sprintTimer = 0f;
    //}

    public void Reset()
    {
        camera = 0;
    }
}
