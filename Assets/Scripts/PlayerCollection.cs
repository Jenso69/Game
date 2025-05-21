using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerCollection : MonoBehaviour
{
    public int score = 0;
    public TMP_Text scoreText;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Collectable"))
        {
            AddScore(1);
            Destroy(other.gameObject);
        
        }
    }



}
