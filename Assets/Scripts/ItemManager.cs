using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    [Header("Ingredients Aquired")]

    public bool Mayo = false;
    [Tooltip("Multiplier for moving")]
    public float MayoSpeedMult;
    float mayoMultHolder;

    public bool Eggs = false;

    public bool Lettuce = false;

    public bool Cheese = false;

    public bool Bacon = false;
    [Tooltip("Multiplier for jumping")]
    public float JumpIncrease;
    float baconIncreaseHolder;

    public bool HotSauce = false;
    [Tooltip("How long the hot sauce keeps you warm")]
    public int HotSauceTime;
    int HotSauceTimeHolder;

    public GameObject player;

    public PlayerSlide slideScript;

    public int Itemcount = 0;

    ItemManager itemManager;
    void Start()
    {
        itemManager = this;
        DontDestroyOnLoad(gameObject);
        mayoMultHolder = MayoSpeedMult;
        baconIncreaseHolder = JumpIncrease;
        HotSauceTimeHolder = HotSauceTime;

        MayoSpeedMult = 1;
        JumpIncrease= 1;
        HotSauceTime = 0;
    }
    void Update()
    {
        if (Mayo == true)
        {
            MayoSpeedMult = mayoMultHolder;
            Itemcount++;
        }
        if (Mayo == false)
        {
            MayoSpeedMult = 1;
            Itemcount--;
        }

        if (Bacon == true)
        {
            JumpIncrease = baconIncreaseHolder;
            Itemcount++;
        }
        if (Bacon == false)
        {
            JumpIncrease = 1;
            Itemcount--;
        }
        if (Eggs == true)
        {
            Itemcount++;
        }
        if (Eggs == false)
        {
            Itemcount--;
        }
        if (Lettuce == true) 
        {
            Itemcount++;
        }
        if (Lettuce == false)
        {
            Itemcount--;
        }
        if (Cheese == true)
        {
            Itemcount++;
        }
        if (Cheese == false)
        {
            Itemcount--;
        }
        if (HotSauce == true)
        {
            Itemcount++;
        }
        if (HotSauce == false)
        {
            Itemcount--;
        }
    }
}
