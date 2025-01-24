using System.Collections;
using System.Collections.Generic;
using System.Xml.Xsl;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem.XR;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
    [Header("External Components")]

    [Tooltip("The transform of the camera")]
    public Transform CamLocation;
    [Tooltip("The transform of the 2d camera")]
    public Transform ExtraCamLocation;
    [Tooltip("The ItemManager")]
    public ItemManager itemManager;

    [Space(10)]

    [Header("Movement Settings")]

    [Tooltip("How fast the player moves")]
    public float moveSpeed = 5f;

    [Tooltip("How fast the player rotates towards the correct angle")]
    public float rotationSpeed = 10f;

    [Tooltip("How powerful the jump is")]
    public float JumpPower;

    //Input on the x axis
    float xInput;
    //Input on the z axis
    float zInput;

    //True if touching the ground
    bool isGrounded;
    
    float MayoMult;

    public bool setStraight = false;
    public bool is2DState;
    public float isFlippedMult = 1;
    //Some components
    Rigidbody rb;
    PlayerSlide slideScript;


    //Movement and relativity to camera
    Vector3 CameraRelative;
    Vector3 MovePower;

    Vector3 playerSize;

    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        slideScript = GetComponent<PlayerSlide>();
        ItemManager itemManager = GetComponent<ItemManager>();
        playerSize = transform.localScale;
    }

    void Update()
    {
        DoJump();
    }

    //Fixedupdate for better movement
    void FixedUpdate()
    {
        if (is2DState == true)
        {
            Do2DMovement();
        }
        if (is2DState == false)
        {
            DoMovement();
        }
        CheckGrounded();
    }

    void DoMovement()
    {
        
        //If not sliding
        if (slideScript.StartedSlide == false)
        {

            //A/D and W/S input
            xInput = Input.GetAxis("Horizontal");
            zInput = Input.GetAxis("Vertical");

            MovePower = new Vector3(xInput, 0, zInput).normalized;

            //Camera and movement
            if (MovePower.magnitude >= 0.1f)
            {
                //Taking the z and x axis from the camera
                Vector3 forward = CamLocation.forward;
                Vector3 right = CamLocation.right;

                //Making it relative/setting y to 0
                forward.y = 0;
                right.y = 0;
                forward.Normalize();
                right.Normalize();

                //Camera relativity
                CameraRelative = forward * MovePower.z + right * MovePower.x;

                //Rotates player to right location
                Quaternion GoingRotate = Quaternion.LookRotation(CameraRelative);
                transform.rotation = Quaternion.Slerp(transform.rotation, GoingRotate, Time.deltaTime * rotationSpeed);
                
                //Moves the player
                Vector3 targetPosition = rb.position + CameraRelative * moveSpeed * itemManager.MayoSpeedMult * Time.fixedDeltaTime;
                rb.MovePosition(targetPosition);
            }
        }
    }
    void Do2DMovement()
    {
        if (setStraight == false)
        {
            
            setStraight = true;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.localScale = new Vector3(playerSize.x, playerSize.y, -playerSize.z);
            isFlippedMult = -1;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.localScale = new Vector3(playerSize.x, playerSize.y, playerSize.z);
            isFlippedMult = 1;
        }

        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 cameraForward = ExtraCamLocation.forward;
        Vector3 cameraRight = ExtraCamLocation.right;

        cameraForward.y = 0f;
        cameraRight.y = 0f;


        cameraForward.Normalize();
        cameraRight.Normalize();

        Vector3 movementDirection = (cameraForward * moveZ + cameraRight * moveX).normalized;
        
        transform.Translate(movementDirection * moveSpeed * Time.deltaTime, Space.World);
    }

    //Simple jump script
    void DoJump()
    {
        
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Debug.Log("JUMPING!!!");
            rb.AddForce(0, JumpPower * itemManager.JumpIncrease * 100, 0);
        }

    }

    //Simple ground check
    void CheckGrounded()
    {
        isGrounded = Physics.Raycast(transform.position, -transform.up, 0.1f);
        Debug.DrawRay(transform.position, -transform.up, Color.magenta, 0.1f);
        slideScript.AirSlided = false;
    }
}
