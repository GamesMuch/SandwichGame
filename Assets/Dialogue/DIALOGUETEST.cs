using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class DIALOGUETEST : MonoBehaviour
{
    public DialogueRunner dialogueRunner;  // Reference to your DialogueRunner
    public string startNode = "Start";    // Node to start the dialogue from (adjust as needed)

    // This method will be called when the GameObject is enabled
    private void OnEnable()
    {
        if (dialogueRunner != null)
        {
            // Start the dialogue from the specified node
            dialogueRunner.StartDialogue(startNode);
        }
    }
}
