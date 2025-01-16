using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSlide : MonoBehaviour
{
    [Tooltip("The increase in movement (forward) when you start sliding")]
    public float SlideSpeed = 1f;
    [Space(20)]
    [Tooltip("The normal material that the player is made of")]
    public PhysicMaterial normalPhysicsMat;
    [Tooltip("The material that makes the player slide")]
    public PhysicMaterial slidingPhysicsMat;

    Rigidbody rb;
    BoxCollider Collider;

    bool StartedSlide;



    // Start is called before the first frame update
    void Start()
    {
        SlideSpeed *= 100;
        rb = GetComponent<Rigidbody>();
        Collider = rb.GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        CheckSlide();
    }
    void CheckSlide()
    {
        if (StartedSlide == false && Input.GetKeyDown(KeyCode.LeftControl))
        {
            StartSlide();
        }
        if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            EndSlide();
        }
    }
    void StartSlide()
    {
        Collider.material = slidingPhysicsMat;
        rb.AddForce(transform.forward * SlideSpeed, ForceMode.Acceleration);
        StartedSlide = true;
        Debug.Log("Started Sliding");
    }
    void EndSlide()
    {
        Collider.material = normalPhysicsMat;
        rb.velocity = Vector3.zero;
        StartedSlide = false;
        Debug.Log("Stopped Sliding");
    }
}
