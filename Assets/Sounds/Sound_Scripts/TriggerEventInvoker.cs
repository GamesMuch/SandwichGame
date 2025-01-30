using UnityEngine;
using UnityEngine.Events;

namespace UnityFundamentals
{

    // The TriggerEventInvoker class handles the invocation of UnityEvents when a collider
    // enters or exits a trigger collider attached to the GameObject this script is assigned to.
    //
    // @author J.C. Wichman

    public class TriggerEventInvoker : MonoBehaviour
    {
        /* 
        //Some more advanced features you can enable if you need a layer or tag filter.
         
        [Space(10)]
        // Defines which layers the trigger should respond to. By default, it responds to all layers.
        // (~ is the bitwise complement operator resulting in the highest integer where all bits are 1).
        public LayerMask layerMask = ~0;
        public string tagFilter = null;
        [Space(10)]
        */

        // UnityEvent that is invoked when another collider enters the trigger.
        public UnityEvent onTriggerEnterEvent;

        // UnityEvent that is invoked when another collider stays on the trigger.
        public UnityEvent onTriggerStayEvent;

        // UnityEvent that is invoked when another collider exits the trigger.
        public UnityEvent onTriggerExitEvent;

        // This method is called when another collider enters the trigger collider
        // attached to the GameObject to which this script is attached.
        // 'other' represents the Collider that enters the trigger.
        void OnTriggerEnter(Collider other)
        {
            // Checks if the script is enabled to perform detection, otherwise exit
            if (!enabled) return;

            //Some more advanced features you can enable if you need a layer or tag filter.
            //if ((layerMask.value & (1 << other.gameObject.layer)) == 0) return;
            //if (!string.IsNullOrEmpty(tagFilter) && !other.gameObject.CompareTag(tagFilter)) return;

            // Invoke the onTriggerEnterEvent when a collider enters the trigger.
            onTriggerEnterEvent?.Invoke();
        }

        // This method is called when another collider stays on the trigger collider
        // attached to the GameObject to which this script is attached.
        // 'other' represents the Collider that stays on the trigger.
        void OnTriggerStay(Collider other)
        {
            // Checks if the script is enabled to perform detection, otherwise exit
            if (!enabled) return;

            //Some more advanced features you can enable if you need a layer or tag filter.
            //if ((layerMask.value & (1 << other.gameObject.layer)) == 0) return;
            //if (!string.IsNullOrEmpty(tagFilter) && !other.gameObject.CompareTag(tagFilter)) return;

            // Invoke the onTriggerEnterEvent when a collider enters the trigger.
            onTriggerStayEvent?.Invoke();
        }

        // This method is called when another collider exits the trigger collider
        // attached to the GameObject to which this script is attached.
        // 'other' represents the Collider that exits the trigger.
        void OnTriggerExit(Collider other)
        {
            // Checks if the script is enabled to perform detection, otherwise exit
            if (!enabled) return;

            //Some more advanced features you can enable if you need a layer or tag filter.
            //if ((layerMask.value & (1 << other.gameObject.layer)) == 0) return;
            //if (!string.IsNullOrEmpty(tagFilter) && !other.gameObject.CompareTag(tagFilter)) return;

            // Invoke the onTriggerExitEvent when a collider exits the trigger.
            onTriggerExitEvent?.Invoke();
        }
    }
}
