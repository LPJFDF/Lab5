using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [Header("Target settings")]
    public Transform target;       // Drag your player here
    public Vector3 offset = new Vector3(0f, 5f, -10f); // Default distance behind/above

    [Header("Smooth settings")]
    public float smoothTime = 0.3f; // Time taken to catch up to target

    private Vector3 currentVelocity = Vector3.zero;

    // LateUpdate runs after regular Update, preventing camera jitter
    void LateUpdate()
    {
        if (target == null) return;

        // Calculate the ideal position for the camera
        Vector3 targetPosition = target.position + offset;

        // Smoothly move the camera from its current position to the target position
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref currentVelocity, smoothTime);
    }
}
