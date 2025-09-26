using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] float delay = 1f;
    bool hasPackage;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Package") && !hasPackage)
        {
            Debug.Log("Pick up Package");
            hasPackage = true;
            Destroy(collision.gameObject, delay);
        }
        if (collision.CompareTag("Customer") && hasPackage)
        {
            Debug.Log("Delivered Package");
            hasPackage = false;
        }

    }
}
