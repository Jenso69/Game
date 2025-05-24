using UnityEngine;

public class LevelEnd : MonoBehaviour
{
    public GameObject endScreen;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("End screen triggered!");  
            Time.timeScale = 0f;
            endScreen.SetActive(true);
            Debug.Log("End screen set active: " + endScreen.activeSelf);
        }
    }
}

