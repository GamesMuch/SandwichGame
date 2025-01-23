using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSlide : MonoBehaviour
{
    [Space(5)]

    //A setting for sliding
    [Header("Sliding Settings")]

    [Tooltip("The increase in movement (forward) when you start sliding")]
    public float SlideSpeed = 1f;
    [Space(10)]

    [Header("Item manager script")]
    [Tooltip("Item Manager")]
    public ItemManager ItemManager;
    [Space(10)]
    //The materials for physics
    [Header("Physics Materials")]

    
    [Tooltip("The normal material that the player is made of")]
    public PhysicMaterial normalPhysicsMat;
    [Tooltip("The material that makes the player slide")]
    public PhysicMaterial slidingPhysicsMat;

    //Components on the player
    Rigidbody rb;
    BoxCollider Collider;
    PlayerMovement playerMovement;


    [Header("Ignore this, please :)")]
    //A check to see if you are sliding
    [Tooltip("Checks if going to slide")]
    public bool StartedSlide;
    [Tooltip("Checks if the player has slid in the air yet")]
    public bool AirSlided;

    //Little code for movement
    Vector3 currentVelocity = new();

    //Getting components and multipying Slide Speed
    void Start()
    {
        SlideSpeed *= 100;
        rb = GetComponent<Rigidbody>();
        Collider = rb.GetComponent<BoxCollider>();
        playerMovement = GetComponent<PlayerMovement>();
        

        currentVelocity.x = 0;
        currentVelocity.z = 0;
        
    }

    
    void Update()
    {
        CheckSlide();
    }

    // Checks if the player wants to slide
    void CheckSlide()
    {
        if (ItemManager.Mayo == true)
        {
            if (StartedSlide == false && Input.GetKeyDown(KeyCode.LeftControl) && AirSlided == false)
            {
                StartSlide();
            }
            if (Input.GetKeyUp(KeyCode.LeftControl))
            {
                EndSlide();
            }
        }
    }

    //If the player starts the slide, add force and make the physics material slippery
    void StartSlide()
    {
        Collider.material = slidingPhysicsMat;
        rb.AddForce(transform.forward * playerMovement.isFlippedMult * SlideSpeed, ForceMode.Acceleration);
        StartedSlide = true;
        Debug.Log("Started Sliding");
        AirSlided = true;
    }

    //If the player ends the slide, stop the velocity and make the physics material normal
    void EndSlide()
    {
        Collider.material = normalPhysicsMat;
        rb.velocity = currentVelocity;
        StartedSlide = false;
        Debug.Log("Stopped Sliding");
    }
}
