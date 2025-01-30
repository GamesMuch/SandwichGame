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
    MeshRenderer childMeshRen;

    void Start()
    {
        childMeshRen = childGameObject.GetComponent<MeshRenderer>();
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
                childMeshRen.enabled = false;
                meshRen.enabled = true;
                Debug.Log("Mayo is true");
                itemManager.Itemcount++;
                itemManager.GoodItems++;
            }
            if (isEquipped == false)
            {
                itemManager.Mayo = false;
                childMeshRen.enabled = true;
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
                childMeshRen.enabled = false;
                meshRen.enabled = true;
                Debug.Log("Chocolate is true");
                itemManager.Itemcount++;
                itemManager.BadItems++;
            }
            if (isEquipped == false)
            {
                itemManager.Chocolate = false;
                childMeshRen.enabled = true;
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
                childMeshRen.enabled = false;
                meshRen.enabled = true;
                Debug.Log("Cheese is true");
                itemManager.Itemcount++;
                itemManager.GoodItems++;
            }
            if (isEquipped == false)
            {
                itemManager.Cheese = false;
                childMeshRen.enabled = true;
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
                childMeshRen.enabled = false;
                meshRen.enabled = true;
                Debug.Log("Strawberry is true");
                itemManager.Itemcount++;
                itemManager.BadItems++;
            }
            if (isEquipped == false)
            {
                itemManager.Strawberry = false;
                childMeshRen.enabled = true;
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
                childMeshRen.enabled = false;
                meshRen.enabled = true;
                Debug.Log("Lettuce is true");
                itemManager.Itemcount++;
                itemManager.GoodItems++;
            }
            if (isEquipped == false)
            {
                itemManager.Lettuce = false;
                childMeshRen.enabled = true;
                meshRen.enabled = false;
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
                childMeshRen.enabled = false;
                meshRen.enabled = true;
                Debug.Log("Cookies is true");
                itemManager.Itemcount++;
                itemManager.BadItems++;
            }
            if (isEquipped == false)
            {
                itemManager.Cookies = false;
                childMeshRen.enabled = true;
                meshRen.enabled = false;
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
                childMeshRen.enabled = false;
                meshRen.enabled = true;
                Debug.Log("Egg is true");
                itemManager.Itemcount++;
                itemManager.GoodItems++;
            }
            if (isEquipped == false)
            {
                itemManager.Eggs = false;
                childMeshRen.enabled = true;
                meshRen.enabled = false;
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
                childMeshRen.enabled = false;
                meshRen.enabled = true;
                Debug.Log("Chicken is true");
                itemManager.Itemcount++;
                itemManager.BadItems++;
            }
            if (isEquipped == false)
            {
                itemManager.Chicken = false;
                childMeshRen.enabled = true;
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
                childMeshRen.enabled = false;
                meshRen.enabled = true;
                Debug.Log("Bacon is true");
                itemManager.Itemcount++;
                itemManager.GoodItems++;
            }
            if (isEquipped == false)
            {
                itemManager.Bacon = false;
                childMeshRen.enabled = true;
                meshRen.enabled = false;
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
                childMeshRen.enabled = false;
                meshRen.enabled = true;
                Debug.Log("Peppers is true");
                itemManager.Itemcount++;
                itemManager.BadItems++;
            }
            if (isEquipped == false)
            {
                itemManager.Peppers = false;
                childMeshRen.enabled = true;
                meshRen.enabled = false;
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
                childMeshRen.enabled = false;
                meshRen.enabled = true;
                Debug.Log("Hotsauce is true");
                itemManager.Itemcount++;
                itemManager.GoodItems++;
            }
            if (isEquipped == false)
            {
                itemManager.HotSauce = false;
                Debug.Log("Hotsauce is false");
                childMeshRen.enabled = true;
                meshRen.enabled = false;
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
                childMeshRen.enabled = false;
                meshRen.enabled = true;
                Debug.Log("Bread is true");
                itemManager.Itemcount++;
                itemManager.BadItems++;
            }
            if (isEquipped == false)
            {
                itemManager.MoreBread = false;
                Debug.Log("Bread is false");
                childMeshRen.enabled = true;
                meshRen.enabled = false;
                itemManager.Itemcount--;
                itemManager.BadItems--;
            }
        }
    }
}

