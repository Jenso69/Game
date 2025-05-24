using UnityEngine;

public class Traps : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Collectable"))
        {

        }
            

    }

   
}
