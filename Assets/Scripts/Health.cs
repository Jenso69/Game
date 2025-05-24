using TMPro;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int points = 5;
    public Vector3 respawnPosition;
    public TMP_Text healthText;
    

    private void Start()
    {
        respawnPosition = transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Trap"))
        {
            Damage(1);

        }

        if (other.CompareTag("CheckPoint"))
        {
            respawnPosition = other.transform.position;
            respawnPosition.y = transform.position.y;

        }
    }
    private void Damage(int value)
    {
        points = points - value;
        healthText.text = $"<b>Health:</b> {points}";

        transform.position = respawnPosition;


        //if (points > 1)

           // gameOverScreen.StartFade();
        //Destroy(gameObject);

    }

}