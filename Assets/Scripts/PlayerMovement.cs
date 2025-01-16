using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem.XR;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
    [Header("Camera")]

    [Tooltip("The transform of the main camera")]
    public Transform CamLocation;
    [Space(10)]

    [Header("Movement Settings")]

    [Tooltip("How fast the player moves")]
    public float moveSpeed = 5f;

    [Tooltip("How fast the player rotates towards the correct angle")]
    public float rotationSpeed = 10f;

    [Tooltip("How powerful the jump is")]
    public float JumpPower;

    float xInput;
    float zInput;
    bool isGrounded;

    Rigidbody rb;

    Vector3 CameraRelative;
    Vector3 MovePower;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        DoJump();
    }
    void FixedUpdate()
    {
        DoMovement();
        CheckGrounded();
    }
    void DoMovement()
    {
        xInput = Input.GetAxis("Horizontal");
        zInput = Input.GetAxis("Vertical");

        MovePower = new Vector3(xInput, 0, zInput).normalized;

        if (MovePower.magnitude >= 0.1f)
        {
            Vector3 forward = CamLocation.forward;
            Vector3 right = CamLocation.right;

            forward.y = 0;
            right.y = 0;
            forward.Normalize();
            right.Normalize();

            CameraRelative = forward * MovePower.z + right * MovePower.x;

            Quaternion GoingRotate = Quaternion.LookRotation(CameraRelative);
            transform.rotation = Quaternion.Slerp(transform.rotation, GoingRotate, Time.deltaTime * rotationSpeed);

            Vector3 targetPosition = rb.position + CameraRelative * moveSpeed * Time.fixedDeltaTime;
            rb.MovePosition(targetPosition);
        }
    }
    void DoJump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Debug.Log("JUMPING!!!");
            rb.AddForce(0, JumpPower * 100, 0);
        }

    }

    void CheckGrounded()
    {
        isGrounded = Physics.Raycast(transform.position, -transform.up, 1.1f);
        Debug.DrawRay(transform.position, -transform.up, Color.magenta, 1.1f);
    }
}
