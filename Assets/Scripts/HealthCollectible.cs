using System.Collections;
using System.Collections.Generic;
using UnityEngine;

<<<<<<< HEAD
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
<<<<<<< HEAD
// Handles collectible health pickups
public class HealthCollectible : MonoBehaviour
{
    public AudioClip collectedClip; // Sound effect for collection
    public GameObject eatParticlePrefab; // Particle effect prefab

    // Trigger when an object enters the collectible zone
    void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the colliding object is the player
        PlayerController controller = other.GetComponent<PlayerController>();

        if (controller != null)
        {
            controller.ChangeHealth(1); // Increase player's health

            // Play sound effect
            if (collectedClip != null)
            {
                AudioSource.PlayClipAtPoint(collectedClip, transform.position);
            }

            // Create and destroy particle effect
            if (eatParticlePrefab != null)
            {
                GameObject eatEffect = Instantiate(eatParticlePrefab, controller.transform.position, Quaternion.identity);
                eatEffect.transform.parent = controller.transform; // Attach to player
                Destroy(eatEffect, 2f); // Remove after 2 seconds
            }

            Destroy(gameObject); // Remove the collectible
        }
        else
        {
            Debug.LogWarning($"No PlayerController found on object: {other.name}");
        }
    }
}
=======
>>>>>>> 38730236 (Added essential Unity project files)
>>>>>>> d6db4e9 (Cleaned and updated .gitattributes with essentials)
=======
>>>>>>> 4e1ec8a0a1b379c977b028a43272ce2eb29e1741
// HealthCollectible: Grants health to the player when collected
public class HealthCollectible : MonoBehaviour
{
    // Public variable to store the sound clip to play when collected
    public AudioClip collectedClip;

    // Trigger event: Executes when another collider enters this GameObject's trigger collider
    void OnTriggerEnter2D(Collider2D other)
    {
        // Attempt to get the PlayerController component from the colliding object
        PlayerController controller = other.GetComponent<PlayerController>();

        // Check if the colliding object is the player and if their health is not already full
        if (controller != null && controller.health < controller.maxHealth)
        {
            // Increase player's health by 1
            controller.ChangeHealth(1);

            // Play the collection sound effect
            controller.PlaySound(collectedClip);

            // Destroy the collectible after it is collected
            Destroy(gameObject);
        }
    }
}



<<<<<<< HEAD
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
>>>>>>> 4e1ec8a0a1b379c977b028a43272ce2eb29e1741
>>>>>>> 38730236 (Added essential Unity project files)
>>>>>>> d6db4e9 (Cleaned and updated .gitattributes with essentials)
=======
>>>>>>> 4e1ec8a0a1b379c977b028a43272ce2eb29e1741
