using UnityEngine;

public class Driver : MonoBehaviour
{
    float steerspeed = 0.5f;
    float movespeed = 0.1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, steerspeed);
        transform.Translate(0, movespeed, 0);
    }
}
