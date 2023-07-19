using UnityEngine;

public class MovingRing : MonoBehaviour
{
    public float rotateSpeed;

    private void FixedUpdate()
    {
        transform.Rotate(Vector3.up * rotateSpeed * Time.fixedDeltaTime);
    }
}
