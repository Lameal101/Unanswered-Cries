using UnityEngine;

public class SkyboxRotator : MonoBehaviour
{
    public float rotationSpeed = 1.0f;

    private void Update()
    {
        // Calculate the new rotation based on the speed and time
        float rotation = Time.deltaTime * rotationSpeed;

        // Get the current rotation of the skybox
        float currentRotation = RenderSettings.skybox.GetFloat("_Rotation");

        // Apply the new rotation
        RenderSettings.skybox.SetFloat("_Rotation", currentRotation + rotation);
    }
}
