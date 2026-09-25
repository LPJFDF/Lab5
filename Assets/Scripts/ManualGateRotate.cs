using UnityEngine;
using UnityEngine.InputSystem;

public class ManualGateRotate : MonoBehaviour
{
    public float rotationSpeed = 120f;
    public bool isActive = true;
    private Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
        //if holding e, rotate clockwise
        if (Keyboard.current.eKey.isPressed)
            
        {
            float rotationThisFrame = rotationSpeed * Time.deltaTime;
            transform.Rotate(0f, rotationThisFrame, 0f);
        }
        if (Keyboard.current.qKey.isPressed)
        {
            float rotationThisFrame = rotationSpeed * Time.deltaTime;
            transform.Rotate(0f, -rotationThisFrame, 0f);
        }
    }
}
