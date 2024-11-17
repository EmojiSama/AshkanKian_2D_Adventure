using System.Collections;
using System.Collections.Generic;
using UnityEngine;

<<<<<<< HEAD
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
<<<<<<< HEAD
// Controls projectile behavior, including movement and collision
public class Projectile : MonoBehaviour
{
    private Rigidbody2D rigidbody2d;

    // Initialize components
    void Awake()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    // Destroy the projectile if it goes out of bounds
    void Update()
    {
=======
>>>>>>> 38730236 (Added essential Unity project files)
>>>>>>> d6db4e9 (Cleaned and updated .gitattributes with essentials)
=======
>>>>>>> 4e1ec8a0a1b379c977b028a43272ce2eb29e1741
// Projectile: Handles the behavior of projectiles in the game
public class Projectile : MonoBehaviour
{
    Rigidbody2D rigidbody2d; // Rigidbody for handling physics interactions

    // Awake is called when the Projectile GameObject is instantiated
    void Awake()
    {
        // Initialize the Rigidbody2D component
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Destroy the projectile if it moves too far away from the origin (out of bounds)
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
        if (transform.position.magnitude > 100.0f)
        {
            Destroy(gameObject);
        }
    }

<<<<<<< HEAD
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
<<<<<<< HEAD
    // Launch the projectile with a specific direction and force
    public void Launch(Vector2 direction, float force)
    {
        rigidbody2d.AddForce(direction * force);
    }

    // Handle collision logic
    void OnCollisionEnter2D(Collision2D other)
    {
        EnemyController enemy = other.collider.GetComponent<EnemyController>();

        if (enemy != null)
        {
            enemy.TakeHit(); // Apply damage to the enemy
        }

        Destroy(gameObject); // Remove the projectile
=======
>>>>>>> 38730236 (Added essential Unity project files)
>>>>>>> d6db4e9 (Cleaned and updated .gitattributes with essentials)
=======
>>>>>>> 4e1ec8a0a1b379c977b028a43272ce2eb29e1741
    // Method to launch the projectile in a specific direction with a given force
    public void Launch(Vector2 direction, float force)
    {
        // Apply a force to the Rigidbody2D to move the projectile
        rigidbody2d.AddForce(direction * force);
    }

    // Triggered upon collision with another object
    void OnCollisionEnter2D(Collision2D other)
    {
        // Check if the projectile collided with an enemy
        EnemyController enemy = other.collider.GetComponent<EnemyController>();
        if (enemy != null)
        {
            // Fix the enemy if it's hit
            enemy.Fix();
        }

        // Destroy the projectile after it collides with something
        Destroy(gameObject);
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
