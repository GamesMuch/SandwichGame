using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class NewBehaviourScript : MonoBehaviour
{
    public int SpinSpeed = 5;
    private void FixedUpdate()
    {
        gameObject.transform.Rotate(0, SpinSpeed * Time.deltaTime, 0);
    }
}
