using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class Delivery : MonoBehaviour
{
    [SerializeField] float delay = 1f;

    bool hasPackage;
    int package = 0;
    public TextMeshProUGUI StorageText;
    private void Start()
    {
        StorageText.gameObject.SetActive(true);
        StorageText.text = "Storage: "+ package.ToString() + "/3";
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Package") && package <= 2)
        {
            Debug.Log("Pick up Package");
            hasPackage = true;
            GetComponent<ParticleSystem>().Play();
            package++;
            Destroy(collision.gameObject, delay);
        }
        if (collision.CompareTag("Customer") && hasPackage)
        {
            Debug.Log("Delivered Package");
            package --;
            if (package == 0)
            {
                hasPackage = false;
                GetComponent<ParticleSystem>().Stop();
            }
            Destroy(collision.gameObject, delay);
        }

    }
    private void Update()
    {
        StorageText.text = "Storage: " + package.ToString() + "/3";
    }
}
