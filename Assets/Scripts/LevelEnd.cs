using UnityEngine;

public class LevelEnd : MonoBehaviour
{
    public GameObject endScreen;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            endScreen.SetActive(true); // Show the end screen
            // No freezing
        }
    }
}

