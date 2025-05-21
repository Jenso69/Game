using UnityEngine;

public class Traps : MonoBehaviour
{
   
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Collectable"))
        {

        }
            

    }

   
}
