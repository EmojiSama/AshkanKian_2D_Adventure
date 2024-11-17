using System.Collections;
using System.Collections.Generic;
using UnityEngine;

<<<<<<< HEAD
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
<<<<<<< HEAD
public class DamageZone : MonoBehaviour
{
    // Apply damage to the player while they remain in the damage zone
    void OnTriggerStay2D(Collider2D other)
    {
        // Check if the object in the zone is the player
        PlayerController controller = other.GetComponent<PlayerController>();

        if (controller != null)
        {
            controller.ChangeHealth(-1); // Reduce player's health
=======
>>>>>>> 38730236 (Added essential Unity project files)
>>>>>>> d6db4e9 (Cleaned and updated .gitattributes with essentials)
=======
>>>>>>> 4e1ec8a0a1b379c977b028a43272ce2eb29e1741
// DamageZone script: Applies damage to the player when they stay within the zone
public class DamageZone : MonoBehaviour
{
    // Trigger event that is called while another collider stays within this trigger
    void OnTriggerStay2D(Collider2D other)
    {
        // Attempt to get the PlayerController component from the object that entered the trigger
        PlayerController controller = other.GetComponent<PlayerController>();

        // If the object has a PlayerController component, apply damage to the player
        if (controller != null)
        {
            // Reduce the player's health by 1
            controller.ChangeHealth(-1);
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
        }
    }
}
