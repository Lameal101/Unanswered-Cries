using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootSteps : MonoBehaviour
{
    public AudioSource FootStepSound; // Assign the AudioSource in the Inspector
    public bool isWalking;
    public CharacterController characterController;

    void Start()
    {
        FootStepSound.Stop(); // Ensure the sound isn't playing at the start
    }

    void Update()
    {
        // Check if any of the movement keys are being held down
        isWalking = Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D);

        if (isWalking && characterController.isGrounded)
        {
            if (!FootStepSound.isPlaying) // Only play the sound if it's not already playing
            {
                FootStepSound.Play();
            }
        }
        else
        {
            if (FootStepSound.isPlaying) // Stop the sound if the player stops walking
            {
                FootStepSound.Stop();
            }
        }
    }
}
