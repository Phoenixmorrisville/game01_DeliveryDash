using UnityEngine;

public class Delivery : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Package"))
        {
            Debug.Log("Pick up Package");
        }
        if (collision.CompareTag("Customer"))
        {
            Debug.Log("Delivered Package");
        }

    }
}
