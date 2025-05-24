using UnityEngine;

public class MovementParticles : MonoBehaviour
{
    public ParticleSystem moveParticles;
    public Rigidbody2D playerRb;
    public float movementThreshold = 0.1f;

    private void Update()
    {
        if (Mathf.Abs(playerRb.linearVelocity.x) > movementThreshold)
        {
            if (!moveParticles.isPlaying)
                moveParticles.Play();
        }
        else
        {
            if (moveParticles.isPlaying)
                moveParticles.Stop();
        }
    }
}
