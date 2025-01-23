using UnityEngine;


[RequireComponent(typeof(Rigidbody))]
public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 2f;
    [SerializeField] private float acceleration = 10f;
    [SerializeField] private float deceleration = 2f;
    [SerializeField] private float fixedZSpeed = 2f;

    private Vector3 currentVelocity = Vector3.zero;

    void Update()
    {
        Move();
        Jump();
    }

    void Move()
    {
        Vector3 targetDirection = new Vector3(Input.GetAxis("Horizontal") * moveSpeed, 0, fixedZSpeed);

        if (Input.GetAxis("Horizontal") != 0)
        {
            currentVelocity = Vector3.Lerp(currentVelocity, targetDirection, acceleration * Time.deltaTime);
        }
        else
        {
            currentVelocity = Vector3.Lerp(currentVelocity, new Vector3(0, 0, fixedZSpeed), deceleration * Time.deltaTime);
        }
        transform.Translate(currentVelocity * Time.deltaTime);
    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 jump = new Vector3(0, 5, 0);
            GetComponent<Rigidbody>().AddForce(jump, ForceMode.Impulse);
        }
    }
}