using UnityEngine;

public class TestComponent : MonoBehaviour
{
    [SerializeField] private int _speed;

    void Update()
    {
        float horizontalDirection = Input.GetAxis("Horizontal");
        Vector3 anglesSpeed = new Vector3(0, 0, _speed);
        gameObject.transform.Rotate(horizontalDirection * Time.deltaTime * anglesSpeed);
    }
}
