using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class enableIngredients : MonoBehaviour
{
    public GameObject goodIngredient;
    public GameObject badIngredient;


    bool GoodActive;
    bool BadActive;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.name == "Spot1")
        {
            if (ItemManager.Instance.Mayo == true)
            {
                goodIngredient.SetActive(true);
            }
            if (ItemManager.Instance.Mayo == false)
            {
                goodIngredient.SetActive(false);
            }
            if (ItemManager.Instance.Chocolate == true)
            {
                badIngredient.SetActive(true);
            }
            if (ItemManager.Instance.Chocolate == false)
            {
                badIngredient.SetActive(false);
            }
        }
        if (gameObject.name == "Spot2")
        {
            if (ItemManager.Instance.Lettuce == true)
            {
                goodIngredient.SetActive(true);
            }
            if (ItemManager.Instance.Lettuce == false)
            {
                goodIngredient.SetActive(false);
            }
            if (ItemManager.Instance.Cookies == true)
            {
                badIngredient.SetActive(true);
            }
            if (ItemManager.Instance.Cookies == false)
            {
                badIngredient.SetActive(false);
            }
        }
        if (gameObject.name == "Spot3")
        {
            if (ItemManager.Instance.Cheese == true)
            {
                goodIngredient.SetActive(true);
            }
            if (ItemManager.Instance.Cheese == false)
            {
                goodIngredient.SetActive(false);
            }
            if (ItemManager.Instance.Strawberry == true)
            {
                badIngredient.SetActive(true);
            }
            if (ItemManager.Instance.Strawberry == false)
            {
                badIngredient.SetActive(false);
            }
        }
        if (gameObject.name == "Spot4")
        {
            if (ItemManager.Instance.Eggs == true)
            {
                goodIngredient.SetActive(true);
            }
            if (ItemManager.Instance.Eggs == false)
            {
                goodIngredient.SetActive(false);
            }
            if (ItemManager.Instance.Chicken == true)
            {
                badIngredient.SetActive(true);
            }
            if (ItemManager.Instance.Chicken == false)
            {
                badIngredient.SetActive(false);
            }
        }
        if (gameObject.name == "Spot5")
        {
            if (ItemManager.Instance.HotSauce == true)
            {
                goodIngredient.SetActive(true);
            }
            if (ItemManager.Instance.HotSauce == false)
            {
                goodIngredient.SetActive(false);
            }
            if (ItemManager.Instance.MoreBread == true)
            {
                badIngredient.SetActive(true);
            }
            if (ItemManager.Instance.MoreBread == false)
            {
                badIngredient.SetActive(false);
            }
        }
        if (gameObject.name == "Spot6")
        {
            if (ItemManager.Instance.Bacon == true)
            {
                goodIngredient.SetActive(true);
            }
            if (ItemManager.Instance.Bacon == false)
            {
                goodIngredient.SetActive(false);
            }
            if (ItemManager.Instance.Peppers == true)
            {
                badIngredient.SetActive(true);
            }
            if (ItemManager.Instance.Peppers == false)
            {
                badIngredient.SetActive(false);
            }
        }
    }
}
