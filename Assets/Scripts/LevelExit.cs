using UnityEngine;

public class LevelExit : MonoBehaviour
{
    

    private void OnTriggerEnter(Collider other)
    { 
        if (other.CompareTag("Player"))
        {
            other.gameObject.SetActive(false);
        //winScreen.StartFade();
        }
    
    }


}
