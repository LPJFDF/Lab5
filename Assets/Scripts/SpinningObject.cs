using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private Vector3 rotationSpeed = new Vector3(0, 50, 0);

    void Update()
    {
        // Rotate the object every frame, independent of frame rate
        transform.Rotate(rotationSpeed * Time.deltaTime);
    }
}
