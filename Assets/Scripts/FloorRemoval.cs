using UnityEngine;

public class FloorRemoval : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Floor"))
        {
            Destroy(other.gameObject);
        }
    }
}
