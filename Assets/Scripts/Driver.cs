using UnityEngine;
using UnityEngine.InputSystem;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerspeed = 0.5f;
    [SerializeField] float movespeed = 0.1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.wKey.isPressed)
        {
            Debug.Log("we are pushing forward");
        }
        else if (Keyboard.current.sKey.isPressed)
        {
            Debug.Log("we are pushing backward");
        }
        if (Keyboard.current.aKey.isPressed)
        {
            Debug.Log("we are pushing left");
        }
        else if (Keyboard.current.dKey.isPressed)
        {
            Debug.Log("we are pushing right");
        }
        transform.Rotate(0, 0, steerspeed);
        transform.Translate(0, movespeed, 0);
    }
}
