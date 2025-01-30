using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class RatMoving : MonoBehaviour
{
    public GameObject RatPlace1;
    public GameObject RatPlace2;
    public GameObject RatOutsideHole;
    public GameObject RatInsideHole;
    public GameObject CheeseInteraction;

    bool isScared = false;
    bool choseTargetHole = false;
    public float MoveSpeed;

    GameObject currentTarget;
    // Start is called before the first frame update
    void Start()
    {
        currentTarget = RatPlace1;
    }

    // Update is called once per frame
    void Update()
    {
        haveTarget();
        doMovement();
    }

    public void GetsSpooped()
    {
        CheeseInteraction.transform.position = transform.position;
        isScared = true;
        MoveSpeed = 0.2f;
    }
    void doMovement()
    {
        transform.LookAt(currentTarget.transform);
        transform.position = Vector3.MoveTowards(transform.position, currentTarget.transform.position, MoveSpeed);
    }
    void haveTarget()
    {
        if (isScared == false)
        {
            if (Vector3.Distance(transform.position, currentTarget.transform.position) <= 0.2f)
            {
                currentTarget = (currentTarget == RatPlace1) ? RatPlace2 : RatPlace1;
            }
        }
        if (isScared == true)
        {
            if (choseTargetHole == false)
            {
                currentTarget = RatOutsideHole;
                choseTargetHole = true;
            }
            if (Vector3.Distance(transform.position, currentTarget.transform.position) <= 0.2f)
            {
                currentTarget = RatInsideHole;
            }
            
        }
    }
}
