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
    public enum sef { none, mayo, chocolate, cheese, strawberry, hotsauce, bread, bacon, peppers, egg, chicken, lettuce, cookie }
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
        
        if (whatChoice == sef.mayo && itemManager.Chocolate == false)
        {
            isEquipped = !isEquipped;
            if (isEquipped == true && itemManager.Itemcount < 7)
            {
                itemManager.Mayo = true;
                childGameObject.SetActive(false);
                meshRen.enabled = true;
                Debug.Log("Mayo is true");
                itemManager.Itemcount++;
                itemManager.GoodItems++;
            }
            if (isEquipped == false)
            {
                itemManager.Mayo = false;
                childGameObject.SetActive(true);
                meshRen.enabled = false;
                Debug.Log("Mayo is false");
                itemManager.Itemcount--;
                itemManager.GoodItems--;
            }

        }
        if (whatChoice == sef.chocolate && itemManager.Mayo == false)
        {
            isEquipped = !isEquipped;
            if (isEquipped == true && itemManager.Itemcount < 7)
            {
                itemManager.Chocolate = true;
                childGameObject.SetActive(false);
                meshRen.enabled = true;
                Debug.Log("Chocolate is true");
                itemManager.Itemcount++;
                itemManager.BadItems++;
            }
            if (isEquipped == false)
            {
                itemManager.Chocolate = false;
                childGameObject.SetActive(true);
                meshRen.enabled = false;
                Debug.Log("Chocolate is false");
                itemManager.Itemcount--;
                itemManager.BadItems--;
            }

        }
        if (whatChoice == sef.cheese && itemManager.Strawberry == false)
        {
            isEquipped = !isEquipped;
            if (isEquipped == true && itemManager.Itemcount < 7)
            {
                itemManager.Cheese = true;
                childGameObject.SetActive(false);
                meshRen.enabled = true;
                Debug.Log("Cheese is true");
                itemManager.Itemcount++;
                itemManager.GoodItems++;
            }
            if (isEquipped == false)
            {
                itemManager.Cheese = false;
                childGameObject.SetActive(true);
                meshRen.enabled = false;
                Debug.Log("Cheese is false");
                itemManager.Itemcount--;
                itemManager.GoodItems--;
            }
        }
        if (whatChoice == sef.strawberry && itemManager.Cheese == false)
        {
            isEquipped = !isEquipped;
            if (isEquipped == true && itemManager.Itemcount < 7)
            {
                itemManager.Strawberry = true;
                childGameObject.SetActive(false);
                meshRen.enabled = true;
                Debug.Log("Strawberry is true");
                itemManager.Itemcount++;
                itemManager.BadItems++;
            }
            if (isEquipped == false)
            {
                itemManager.Strawberry = false;
                childGameObject.SetActive(true);
                meshRen.enabled = false;
                Debug.Log("Strawberry is false");
                itemManager.Itemcount--;
                itemManager.BadItems--;
            }
        }
        if (whatChoice == sef.lettuce && itemManager.Cookies == false)
        {
            isEquipped = !isEquipped;
            if (isEquipped == true && itemManager.Itemcount < 7)
            {
                itemManager.Lettuce = true;
                childGameObject.SetActive(false);
                meshRen.enabled = true;
                Debug.Log("Lettuce is true");
                itemManager.Itemcount++;
                itemManager.GoodItems++;
            }
            if (isEquipped == false)
            {
                itemManager.Lettuce = false;
                childGameObject.SetActive(true);
                Debug.Log("Lettuce is false");
                itemManager.Itemcount--;
                itemManager.GoodItems--;
            }
        }
        if (whatChoice == sef.cookie && itemManager.Lettuce == false)
        {
            isEquipped = !isEquipped;
            if (isEquipped == true && itemManager.Itemcount < 7)
            {
                itemManager.Cookies = true;
                childGameObject.SetActive(false);
                meshRen.enabled = true;
                Debug.Log("Cookies is true");
                itemManager.Itemcount++;
                itemManager.BadItems++;
            }
            if (isEquipped == false)
            {
                itemManager.Cookies = false;
                childGameObject.SetActive(true);
                Debug.Log("Cookies is false");
                itemManager.Itemcount--;
                itemManager.BadItems--;
            }
        }
        if (whatChoice == sef.egg && itemManager.Chicken == false)
        {
            isEquipped = !isEquipped;
            if (isEquipped == true && itemManager.Itemcount < 7)
            {
                itemManager.Eggs = true;
                childGameObject.SetActive(false);
                meshRen.enabled = true;
                Debug.Log("Egg is true");
                itemManager.Itemcount++;
                itemManager.GoodItems++;
            }
            if (isEquipped == false)
            {
                itemManager.Eggs = false;
                childGameObject.SetActive(true);
                Debug.Log("Egg is false");
                itemManager.Itemcount--;
                itemManager.GoodItems--;
            }

        }
        if (whatChoice == sef.chicken && itemManager.Eggs == false)
        {
            isEquipped = !isEquipped;
            if (isEquipped == true && itemManager.Itemcount < 7)
            {
                itemManager.Chicken = true;
                childGameObject.SetActive(false);
                meshRen.enabled = true;
                Debug.Log("Chicken is true");
                itemManager.Itemcount++;
                itemManager.BadItems++;
            }
            if (isEquipped == false)
            {
                itemManager.Chicken = false;
                childGameObject.SetActive(true);
                Debug.Log("Chicken is false");
                itemManager.Itemcount--;
                itemManager.BadItems--;
            }

        }


        if (whatChoice == sef.bacon && itemManager.Peppers == false)
        {
            isEquipped = !isEquipped;
            if (isEquipped == true && itemManager.Itemcount < 7)
            {
                itemManager.Bacon = true;
                childGameObject.SetActive(false);
                meshRen.enabled = true;
                Debug.Log("Bacon is true");
                itemManager.Itemcount++;
                itemManager.GoodItems++;
            }
            if (isEquipped == false)
            {
                itemManager.Bacon = false;
                childGameObject.SetActive(true);
                Debug.Log("Bacon is false");
                itemManager.Itemcount--;
                itemManager.GoodItems--;
            }
        }
        if (whatChoice == sef.peppers && itemManager.Bacon == false)
        {
            isEquipped = !isEquipped;
            if (isEquipped == true && itemManager.Itemcount < 7)
            {
                itemManager.Peppers = true;
                childGameObject.SetActive(false);
                meshRen.enabled = true;
                Debug.Log("Peppers is true");
                itemManager.Itemcount++;
                itemManager.BadItems++;
            }
            if (isEquipped == false)
            {
                itemManager.Bacon = false;
                childGameObject.SetActive(true);
                Debug.Log("Peppers is false");
                itemManager.Itemcount--;
                itemManager.BadItems--;
            }
        }


        if (whatChoice == sef.hotsauce && itemManager.MoreBread == false)
        {
            isEquipped = !isEquipped;
            if (isEquipped == true && itemManager.Itemcount < 7)
            {
                itemManager.HotSauce = true;
                childGameObject.SetActive(false);
                meshRen.enabled = true;
                Debug.Log("Hotsauce is true");
                itemManager.Itemcount++;
                itemManager.GoodItems++;
            }
            if (isEquipped == false)
            {
                itemManager.HotSauce = false;
                Debug.Log("Hotsauce is false");
                childGameObject.SetActive(true);
                itemManager.Itemcount--;
                itemManager.GoodItems--;
            }
        }
        if (whatChoice == sef.bread && itemManager.HotSauce == false)
        {
            isEquipped = !isEquipped;
            if (isEquipped == true && itemManager.Itemcount < 7)
            {
                itemManager.MoreBread = true;
                childGameObject.SetActive(false);
                meshRen.enabled = true;
                Debug.Log("Bread is true");
                itemManager.Itemcount++;
                itemManager.BadItems++;
            }
            if (isEquipped == false)
            {
                itemManager.MoreBread = false;
                Debug.Log("Bread is false");
                childGameObject.SetActive(true);
                itemManager.Itemcount--;
                itemManager.BadItems--;
            }
        }
    }
}

