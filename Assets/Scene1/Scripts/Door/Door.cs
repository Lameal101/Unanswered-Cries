using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject uiElement; // The UI element to enable
    public GameObject player;    // The player GameObject to detect
    public Animator Hinge; //The door hinge
    public bool open = false;

    void Start()
    {
        uiElement.SetActive(false);
        Hinge.SetBool("Open",false);
        Hinge.SetBool("Close",true);
    }

    void OnTriggerStay(Collider other)
    {
        // Check if the object entering the trigger is the player
        if (other.gameObject == player)
        {
            uiElement.SetActive(true);
            if (Input.GetKeyDown(KeyCode.F))
        {
            open = !open; // Toggle open state
            Hinge.SetBool("Open", open);
            Hinge.SetBool("Close", !open);
        }
        }
    }

    void OnTriggerExit(Collider other)
    {
        // Disable the UI element when the player exits the trigger
        if (other.gameObject == player)
        {
            uiElement.SetActive(false);
        }
    }
}
