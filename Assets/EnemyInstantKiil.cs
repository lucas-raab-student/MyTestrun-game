using UnityEngine;

public class EnemyInstantKill : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlayerHealth playerHealth = other.GetComponent<PlayerHealth>();
        if (playerHealth != null)
        {
            playerHealth.TakeDamage(9999); // The number doesn't matter now
        }
    }
}
