using UnityEngine;

public class Collision : MonoBehaviour
{
   void oncolisionEnter2D(Collision2D collision)
   {
       Debug.Log("Ouch!");
    }
}
