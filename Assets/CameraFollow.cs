using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform ball;
    [SerializeField] private float smoothSpeed = 5f;
    private Vector3 offset; 

    void Start()
    {
        offset = transform.position - ball.position;
    }

    void LateUpdate()
    {
        Vector3 targetPosition = new Vector3(transform.position.x, transform.position.y, ball.position.z + offset.z);
        transform.position = Vector3.Lerp(transform.position, targetPosition, smoothSpeed * Time.deltaTime);
    }
}