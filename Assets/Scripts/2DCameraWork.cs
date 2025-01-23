using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CameraWork2D : MonoBehaviour
{
    public UnityEvent onTriggerEnter;
    public UnityEvent onTriggerExit;
    public PlayerMovement player;

    public float TransformationCooldown;
    float timeUntilAgain;
    bool canTransform = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (canTransform == false)
        {
            timeUntilAgain += Time.deltaTime;
            if (timeUntilAgain > TransformationCooldown)
            {
                canTransform = true;
                timeUntilAgain = 0;
            }
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player"&& canTransform == true)
        {
            canTransform = false;
            onTriggerEnter.Invoke();
            player.is2DState = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            canTransform = false;
            onTriggerExit.Invoke();
            player.is2DState = false;
            player.setStraight = false;
            player.isFlippedMult = 1;
        }
    }
}
