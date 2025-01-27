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

    public bool Peppers = false;

    public bool Chocolate = false;

    public bool Chicken = false;

    public bool Cookies = false;

    public bool MoreBread = false;

    public bool Strawberry = false;
    public GameObject player;

    public PlayerSlide slideScript;

    public int Itemcount = 0;
    public int GoodItems = 0;
    public int BadItems = 0;

    ItemManager itemManager;

    public static ItemManager Instance { get; private set; }
    private void Awake()
    {
        // If there is an instance, and it's not me, delete myself.

        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }
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
        if (Itemcount < 6)
        {

            if (Mayo == true)
            {
                MayoSpeedMult = mayoMultHolder;

            }
            if (Mayo == false)
            {
                MayoSpeedMult = 1;

            }


            if (Bacon == true)
            {
                JumpIncrease = baconIncreaseHolder;

            }
            if (Bacon == false)
            {
                JumpIncrease = 1;

            }
            if (Eggs == true)
            {

            }
            if (Eggs == false)
            {

            }
            if (Lettuce == true)
            {

                Physics.gravity = new Vector3(0, -9, 0);
            }
            if (Lettuce == false)
            {

                Physics.gravity = new Vector3(0, -9.81f, 0);
            }
            if (Cheese == true)
            {

            }
            if (Cheese == false)
            {

            }
            if (HotSauce == true)
            {

            }
            if (HotSauce == false)
            {

            }
        }
    }
}
