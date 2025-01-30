using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class enableIngredients : MonoBehaviour
{
    public GameObject goodIngredient;
    public GameObject badIngredient;

    public ItemManager iM;

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
            if (iM.Mayo == true)
            {
                goodIngredient.SetActive(true);
            }
            if (iM.Mayo == false)
            {
                goodIngredient.SetActive(false);
            }
            if (iM.Chocolate == true)
            {
                badIngredient.SetActive(true);
            }
            if (iM.Chocolate == false)
            {
                badIngredient.SetActive(false);
            }
        }
        if (gameObject.name == "Spot2")
        {
            if (iM.Lettuce == true)
            {
                goodIngredient.SetActive(true);
            }
            if (iM.Lettuce == false)
            {
                goodIngredient.SetActive(false);
            }
            if (iM.Cookies == true)
            {
                badIngredient.SetActive(true);
            }
            if (iM.Cookies == false)
            {
                badIngredient.SetActive(false);
            }
        }
        if (gameObject.name == "Spot3")
        {
            if (iM.Cheese == true)
            {
                goodIngredient.SetActive(true);
            }
            if (iM.Cheese == false)
            {
                goodIngredient.SetActive(false);
            }
            if (iM.Strawberry == true)
            {
                badIngredient.SetActive(true);
            }
            if (iM.Strawberry == false)
            {
                badIngredient.SetActive(false);
            }
        }
        if (gameObject.name == "Spot4")
        {
            if (iM.Eggs == true)
            {
                goodIngredient.SetActive(true);
            }
            if (iM.Eggs == false)
            {
                goodIngredient.SetActive(false);
            }
            if (iM.Chicken == true)
            {
                badIngredient.SetActive(true);
            }
            if (iM.Chicken == false)
            {
                badIngredient.SetActive(false);
            }
        }
        if (gameObject.name == "Spot5")
        {
            if (iM.HotSauce == true)
            {
                goodIngredient.SetActive(true);
            }
            if (iM.HotSauce == false)
            {
                goodIngredient.SetActive(false);
            }
            if (iM.MoreBread == true)
            {
                badIngredient.SetActive(true);
            }
            if (iM.MoreBread == false)
            {
                badIngredient.SetActive(false);
            }
        }
        if (gameObject.name == "Spot6")
        {
            if (iM.Bacon == true)
            {
                goodIngredient.SetActive(true);
            }
            if (iM.Bacon == false)
            {
                goodIngredient.SetActive(false);
            }
            if (iM.Peppers == true)
            {
                badIngredient.SetActive(true);
            }
            if (iM.Peppers == false)
            {
                badIngredient.SetActive(false);
            }
        }
    }
}
