using UnityEngine;

public class TestComponent : MonoBehaviour
{
    void Update()
    {
        float horizontalDirection = Input.GetAxis("Horizontal");
        Vector3 anglesSpeed = new Vector3(0, 0, -30);
        gameObject.transform.Rotate(horizontalDirection * Time.deltaTime * anglesSpeed);
    }
}
