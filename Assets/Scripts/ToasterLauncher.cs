using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ToasterLauncher : MonoBehaviour
{
    [Header("Public Components")]
    public GameObject ThePlayer;
    public Animation ToastAnim;

    private Rigidbody playerRb;
    [Space(5)]
    [Header("Toaster Settings")]
    [Tooltip("How long the toaster cant be used again")]
    public float toasterCooldown = 0.5f;

    float WaitReset = 0f;
    bool GoingShoot = false;
    bool DidShoot = false;

    [Tooltip("How far the toaster shoots the player [WARNING: VERY POWERFUL]")]
    public int ToastBoostPower = 0;
    


    private void Start()
    {
        playerRb = ThePlayer.GetComponent<Rigidbody>();
        ToastAnim = gameObject.GetComponent<Animation>();
        ToastBoostPower *= 100;
    }
    private void Update()
    {
        if (DidShoot == true)
        {
            WaitReset += Time.deltaTime;
            if (WaitReset > toasterCooldown)
            {
                DidShoot = false;
            }
        }
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player" && DidShoot == false)
        {
            GoingShoot = true;
            ToastAnim.Play("ToasterFallRise");
        }
    }
    void OnTriggerStay(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            GoingShoot = true;
        }
    }
    private void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            GoingShoot = false;
        }
    }
    public void ShootPlayer()
    {
        Debug.Log("GOINGTOSHOOT");
        if (GoingShoot)
        {
            playerRb.AddForce(0, ToastBoostPower, 0);
            DidShoot = true;
        }
    }

}
