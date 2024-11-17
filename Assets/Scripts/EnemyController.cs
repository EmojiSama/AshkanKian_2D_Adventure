using System.Collections;
using System.Collections.Generic;
using UnityEngine;

<<<<<<< HEAD
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
<<<<<<< HEAD
// Controls enemy movement, interactions, and behavior
public class EnemyController : MonoBehaviour
{
    // Enemy properties
    public float speed;               // Movement speed
    public bool vertical;             // True for vertical movement, false for horizontal
    public float changeTime;          // Time interval to switch direction
    public ParticleSystem smokeEffect; // Effect when enemy is "fixed"

    // Private variables
    private Rigidbody2D rigidbody2d;
    private Animator animator;
    private AudioSource footstepAudioSource;
    private float timer;
    private int direction = 1;        // Current direction (1 or -1)
    private bool broken = true;       // Active state
    private bool isFixed = false;     // Fixed state
    public GameObject stunParticlePrefab; // Stun effect prefab

    // Initialization
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        footstepAudioSource = GetComponent<AudioSource>();
        timer = changeTime;
    }

    // Handle updates (skip if inactive or fixed)
    void Update()
    {
        if (!broken || isFixed) return;
    }

    // Handle physics and movement
    void FixedUpdate()
    {
        if (!broken || isFixed) return;

        // Timer for direction change
        timer -= Time.deltaTime;
=======
>>>>>>> 38730236 (Added essential Unity project files)
>>>>>>> d6db4e9 (Cleaned and updated .gitattributes with essentials)
=======
>>>>>>> 4e1ec8a0a1b379c977b028a43272ce2eb29e1741
// EnemyController: Controls enemy movement and interaction with the player
public class EnemyController : MonoBehaviour
{
    // Public variables (editable in Unity Inspector)
    public float speed;             // Speed of the enemy movement
    public bool vertical;           // Determines if the enemy moves vertically
    public float changeTime;        // Time interval for direction change
    public ParticleSystem smokeEffect; // Effect played when the enemy is "fixed"

    // Private variables (used internally)
    Rigidbody2D rigidbody2d;        // Physics component for movement
    Animator animator;              // Animation component
    float timer;                    // Countdown timer for direction changes
    int direction = 1;              // Current movement direction
    bool broken = true;             // Indicates if the enemy is active

    // Start is called before the first frame update
    void Start()
    {
        // Initialize components and timer
        rigidbody2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        timer = changeTime;
    }

    // Update is called every frame
    void Update()
    {
        // Skip the update logic if the enemy is not active
        if (!broken)
        {
            return;
        }
    }

    // FixedUpdate has the same call rate as the physics system
    void FixedUpdate()
    {
        // Skip physics logic if the enemy is not active
        if (!broken)
        {
            return;
        }

        // Countdown for direction change
        timer -= Time.deltaTime;

        // Change direction when the timer runs out
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
        if (timer < 0)
        {
            direction = -direction;
            timer = changeTime;
        }

<<<<<<< HEAD
<<<<<<< HEAD
        // Calculate new position based on movement type
=======
<<<<<<< HEAD
        // Calculate new position based on movement type
=======
<<<<<<< HEAD
        // Update position and animation based on movement type
=======
        // Calculate new position based on movement type
>>>>>>> 4e1ec8a0a1b379c977b028a43272ce2eb29e1741
>>>>>>> 38730236 (Added essential Unity project files)
>>>>>>> d6db4e9 (Cleaned and updated .gitattributes with essentials)
=======
        // Calculate new position based on movement type
>>>>>>> 4e1ec8a0a1b379c977b028a43272ce2eb29e1741
        Vector2 position = rigidbody2d.position;

        if (vertical)
        {
<<<<<<< HEAD
<<<<<<< HEAD
            // Move vertically
            position.y = position.y + speed * direction * Time.deltaTime;
=======
<<<<<<< HEAD
            // Move vertically
            position.y = position.y + speed * direction * Time.deltaTime;
=======
<<<<<<< HEAD
            position.y += speed * direction * Time.deltaTime;
=======
            // Move vertically
            position.y = position.y + speed * direction * Time.deltaTime;
>>>>>>> 4e1ec8a0a1b379c977b028a43272ce2eb29e1741
>>>>>>> 38730236 (Added essential Unity project files)
>>>>>>> d6db4e9 (Cleaned and updated .gitattributes with essentials)
=======
            // Move vertically
            position.y = position.y + speed * direction * Time.deltaTime;
>>>>>>> 4e1ec8a0a1b379c977b028a43272ce2eb29e1741
            animator.SetFloat("Move X", 0);
            animator.SetFloat("Move Y", direction);
        }
        else
        {
<<<<<<< HEAD
<<<<<<< HEAD
            // Move horizontally
            position.x = position.x + speed * direction * Time.deltaTime;
=======
<<<<<<< HEAD
            // Move horizontally
            position.x = position.x + speed * direction * Time.deltaTime;
=======
<<<<<<< HEAD
            position.x += speed * direction * Time.deltaTime;
=======
            // Move horizontally
            position.x = position.x + speed * direction * Time.deltaTime;
>>>>>>> 4e1ec8a0a1b379c977b028a43272ce2eb29e1741
>>>>>>> 38730236 (Added essential Unity project files)
>>>>>>> d6db4e9 (Cleaned and updated .gitattributes with essentials)
=======
            // Move horizontally
            position.x = position.x + speed * direction * Time.deltaTime;
>>>>>>> 4e1ec8a0a1b379c977b028a43272ce2eb29e1741
            animator.SetFloat("Move X", direction);
            animator.SetFloat("Move Y", 0);
        }

<<<<<<< HEAD
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
<<<<<<< HEAD
        rigidbody2d.MovePosition(position);
    }

    // Handle collisions
    void OnCollisionEnter2D(Collision2D other)
    {
        // Player interaction
        PlayerController player = other.gameObject.GetComponent<PlayerController>();
        if (player != null)
        {
            player.ChangeHealth(-1);
            return;
        }

        // Projectile interaction
        Projectile projectile = other.gameObject.GetComponent<Projectile>();
        if (projectile != null)
        {
            TakeHit(); // Trigger hit logic
        }
    }

    // Manage enemy hit behavior
    public void TakeHit()
    {
        if (isFixed) return;

        EnterFixState(); // Fix enemy immediately
        StartCoroutine(FlashRed()); // Flash red for visual feedback
    }

    // Temporarily flash enemy red
    private IEnumerator FlashRed()
    {
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        if (spriteRenderer != null)
        {
            spriteRenderer.color = Color.red;
            yield return new WaitForSeconds(1.0f);
            spriteRenderer.color = Color.white;
        }
    }

    // Transition to fixed state
    private void EnterFixState()
    {
        isFixed = true;
        broken = false;
        animator.SetTrigger("Fixed");
        smokeEffect.Stop();
        GetComponent<Rigidbody2D>().simulated = false;

        if (GameManager.Instance != null)
        {
            GameManager.Instance.EnemyFixed();
        }
        else
        {
            Debug.LogError("GameManager instance is null!");
        }

        if (footstepAudioSource != null && footstepAudioSource.isPlaying)
        {
            footstepAudioSource.Stop();
        }
    }

    // Permanently fix the enemy
    public void Fix()
    {
        isFixed = true;
        broken = false;
        animator.SetTrigger("Fixed");
        smokeEffect.Stop();
        GetComponent<Rigidbody2D>().simulated = false;
        Debug.Log("Enemy has been permanently fixed!");
=======
>>>>>>> 38730236 (Added essential Unity project files)
>>>>>>> d6db4e9 (Cleaned and updated .gitattributes with essentials)
=======
>>>>>>> 4e1ec8a0a1b379c977b028a43272ce2eb29e1741
        // Apply the new position
        rigidbody2d.MovePosition(position);
    }

    // Detect collisions with other objects
    void OnCollisionEnter2D(Collision2D other)
    {
        // Check if the collided object is the player
        PlayerController player = other.gameObject.GetComponent<PlayerController>();

        if (player != null)
        {
            // Reduce player's health by 1 on collision
            player.ChangeHealth(-1);
        }
    }

    // Fix method: Deactivates the enemy and plays a "fixed" animation
    public void Fix()
    {
        broken = false;                             // Mark enemy as inactive
        GetComponent<Rigidbody2D>().simulated = false; // Disable physics simulation
        animator.SetTrigger("Fixed");              // Play the "fixed" animation
        smokeEffect.Stop();                        // Stop the smoke effect
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
