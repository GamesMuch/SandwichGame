using Cinemachine.Editor;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Timeline;

public class PickupScript : MonoBehaviour
{
    [Header("Other Object")]
    public ItemManager itemManager;
    public GameObject childGameObject;
    [Space(5)]

    bool isEquipped = false;

    [Tooltip("What ingredient this is")]
    public enum sef { none, mayo, cheese, hotsauce, bacon, egg, lettuce }
    public sef whatChoice = sef.none;


    MeshRenderer meshRen;

    void Start()
    {

        meshRen = GetComponent<MeshRenderer>();
    }
    private void Update()
    {

    }
    void FixedUpdate()
    {

    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player" && Input.GetKeyDown(KeyCode.E))
        {
            flipTrue();
        }

    }
    void flipTrue()
    {
        if (whatChoice == sef.mayo)
        {
            isEquipped = !isEquipped;
            if (isEquipped == true)
            {
                itemManager.Mayo = true;
                childGameObject.SetActive(false);
                meshRen.enabled = true;
            }
            if (isEquipped == false)
            {
                itemManager.Mayo = false;
                childGameObject.SetActive(true);
                meshRen.enabled = false;
            }

        }
        if (whatChoice == sef.cheese)
        {
            isEquipped = !isEquipped;
            if (isEquipped == true)
            {
                itemManager.Cheese = true;
                childGameObject.SetActive(false);
                meshRen.enabled = true;
            }
            if (isEquipped == false)
            {
                itemManager.Cheese = false;
                childGameObject.SetActive(true);
                meshRen.enabled = false;
            }
        }
        if (whatChoice == sef.lettuce)
        {
            isEquipped = !isEquipped;
            if (isEquipped == true)
            {
                itemManager.Lettuce = true;
                childGameObject.SetActive(false);
                meshRen.enabled = true;
            }
            if (isEquipped == false)
            {
                itemManager.Lettuce = false;
                childGameObject.SetActive(true);
            }
        }
        if (whatChoice == sef.egg)
        {
            isEquipped = !isEquipped;
            if (isEquipped == true)
            {
                itemManager.Eggs = true;
                childGameObject.SetActive(false);
                meshRen.enabled = true;
            }
            if (isEquipped == false)
            {
                itemManager.Eggs = false;
                childGameObject.SetActive(true);
            }

        }
        if (whatChoice == sef.bacon)
        {
            isEquipped = !isEquipped;
            if (isEquipped == true)
            {
                itemManager.Bacon = true;
                childGameObject.SetActive(false);
                meshRen.enabled = true;
            }
            if (isEquipped == false)
            {
                itemManager.Bacon = false;
                childGameObject.SetActive(true);
            }
        }
        if (whatChoice == sef.hotsauce)
        {
            isEquipped = !isEquipped;
            if (isEquipped == true)
            {
                itemManager.HotSauce = true;
                childGameObject.SetActive(false);
                meshRen.enabled = true;
            }
            if (isEquipped == false)
            {
                itemManager.HotSauce = false;
                childGameObject.SetActive(true);
            }
        }
    }
}

