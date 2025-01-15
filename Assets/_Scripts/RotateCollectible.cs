using UnityEngine;

public class RotateCollectible : MonoBehaviour
{
    public float rotationSpeed = 50f; // Adjust the rotation speed

    void Update()
    {
        // Rotate the cube continuously
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }
}