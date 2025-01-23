using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckIfWork : MonoBehaviour
{
    ItemManager itemManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerStay(Collider collider)
    {
        if (collider.gameObject.tag == "Player" && itemManager.Itemcount == 6 && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Shmenis");
        }
    }
}
