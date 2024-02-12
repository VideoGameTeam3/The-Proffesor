using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Temporary : MonoBehaviour
{
    public float displayTime = 3f; // Time in seconds to display the message

    void Start()
    {
        StartCoroutine(ShowAndHideMessage());
    }

    IEnumerator ShowAndHideMessage()
    {
        // Get the Text component
        Text textComponent = GetComponent<Text>();

        // Check if the Text component is not null
        if (textComponent != null)
        {
            // Display the message
            textComponent.enabled = true;

            // Wait for the specified time
            yield return new WaitForSeconds(displayTime);

            // Hide the message
            textComponent.enabled = false;
        }
        else
        {
            Debug.LogError("Text component not found on the GameObject.", this);
        }
    }
}
