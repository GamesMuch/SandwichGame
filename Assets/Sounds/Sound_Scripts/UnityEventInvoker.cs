using UnityEngine;
using UnityEngine.Events;

namespace UnityFundamentals
{

    // Simple helper class to attach a number of actions to a UnityEvent and invoke it from somewhere else.
    // The description is ignored, that is for you only.
    //
    // @author J.C. Wichman

    public class UnityEventInvoker : MonoBehaviour
    {
        [SerializeField] private string description;
        [SerializeField] private UnityEvent onEvent;

        public void InvokeOnEvent()
        {
            if (enabled) onEvent?.Invoke();
        }
    }
}
