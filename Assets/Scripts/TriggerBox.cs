using UnityEngine;

public class TriggerBox : MonoBehaviour
{
    [Tooltip("Transform that defines the respawn position and direction.")]
    public Transform respawnPoint;

    [Tooltip("Extra velocity (m/s) to add in the respawn forward direction.")]
    public float power = 5f;

    private void OnTriggerEnter(Collider other)
    {
        Rigidbody rb = other.attachedRigidbody;
        if (rb != null && respawnPoint != null)
        {
            // Save current speed
            float currentSpeed = rb.linearVelocity.magnitude;

            // Move the object to the respawn point
            rb.position = respawnPoint.position;

            // Calculate new direction and add power
            Vector3 newVelocity = respawnPoint.forward * (currentSpeed + power);

            // Apply the new velocity
            rb.linearVelocity = newVelocity;

            // Optionally reset spin if you want
            // rb.angularVelocity = Vector3.zero;
        }
    }
}
