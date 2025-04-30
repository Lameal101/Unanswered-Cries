using UnityEngine;

public class EnableUIForPlayer : MonoBehaviour
{
    public GameObject uiElement; // The UI element to enable
    public GameObject player;    // The player GameObject to detect

    void Start()
    {
        // Ensure the UI element is initially disabled
        if (uiElement != null)
        {
            uiElement.SetActive(false);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        // Check if the object entering the trigger is the player
        if (other.gameObject == player)
        {
            if (uiElement != null)
            {
                uiElement.SetActive(true);
                Debug.Log("UI element enabled by: " + other.gameObject.name);
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        // Disable the UI element when the player exits the trigger
        if (other.gameObject == player)
        {
            if (uiElement != null)
            {
                uiElement.SetActive(false);
                Debug.Log("UI element disabled by: " + other.gameObject.name);
            }
        }
    }
}
