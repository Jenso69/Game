using UnityEngine;

public class LevelEnd : MonoBehaviour
{
    public GameObject endScreen; // Assign a UI canvas or panel in the inspector

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Time.timeScale = 0f; // Pause game
            endScreen.SetActive(true); // Show end UI
        }
    }
}
