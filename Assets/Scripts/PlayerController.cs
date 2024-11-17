using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

<<<<<<< HEAD
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
<<<<<<< HEAD
// Controls player movement, health, combat, and interactions
public class PlayerController : MonoBehaviour
{
    // Movement variables
    public InputAction MoveAction;
    public float speed = 3.0f;
    private Rigidbody2D rigidbody2d;
    private Vector2 move;
    private Vector2 moveDirection = new Vector2(1, 0);

    // Health system
    public int maxHealth = 5;
    private int currentHealth;
    public int health { get { return currentHealth; } }
    public float timeInvincible = 2.0f;
    private bool isInvincible;
    private float damageCooldown;

    // Animation and combat
    private Animator animator;
    public GameObject projectilePrefab;
    public InputAction launchAction;
    public InputAction talkAction;
    public BloodOverlayController bloodOverlay;

    // Audio
    private AudioSource audioSource;
=======
>>>>>>> 38730236 (Added essential Unity project files)
>>>>>>> d6db4e9 (Cleaned and updated .gitattributes with essentials)
=======
>>>>>>> 4e1ec8a0a1b379c977b028a43272ce2eb29e1741
// PlayerController: Handles player movement, health, combat, and interactions
public class PlayerController : MonoBehaviour
{
    // Movement variables
    public InputAction MoveAction;         // Input for movement
    Rigidbody2D rigidbody2d;               // Physics component for movement
    Vector2 move;                          // Current movement direction
    public float speed = 3.0f;             // Movement speed

    // Health system variables
    public int maxHealth = 5;              // Maximum health
    int currentHealth;                     // Current health
    public int health { get { return currentHealth; } } // Public getter for current health

    // Temporary invincibility variables
    public float timeInvincible = 2.0f;    // Duration of invincibility after damage
    bool isInvincible;                     // Whether the player is currently invincible
    float damageCooldown;                  // Timer for invincibility cooldown

    // Animation variables
    Animator animator;                     // Animation controller
    Vector2 moveDirection = new Vector2(1, 0); // Default facing direction

    // Combat and interaction variables
    public GameObject projectilePrefab;    // Prefab for projectiles
    public InputAction launchAction;       // Input for launching projectiles
    public InputAction talkAction;         // Input for initiating NPC interaction

    // Audio variables
    AudioSource audioSource;               // Audio source for sound effects
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

    // Initialization
    void Start()
    {
<<<<<<< HEAD
<<<<<<< HEAD
        // Enable inputs
=======
<<<<<<< HEAD
        // Enable inputs
=======
<<<<<<< HEAD
=======
        // Enable inputs
>>>>>>> 4e1ec8a0a1b379c977b028a43272ce2eb29e1741
>>>>>>> 38730236 (Added essential Unity project files)
>>>>>>> d6db4e9 (Cleaned and updated .gitattributes with essentials)
=======
        // Enable inputs
>>>>>>> 4e1ec8a0a1b379c977b028a43272ce2eb29e1741
        MoveAction.Enable();
        launchAction.Enable();
        launchAction.performed += Launch;

        talkAction.Enable();
        talkAction.performed += FindFriend;

<<<<<<< HEAD
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
<<<<<<< HEAD
        rigidbody2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
        currentHealth = maxHealth;
    }

    void OnEnable()
    {
        if (launchAction != null)
        {
            launchAction.performed += Launch;
        }
    }

    void OnDisable()
    {
        if (launchAction != null)
        {
            launchAction.performed -= Launch;
        }
    }

    // Handles player movement and invincibility cooldown
    void Update()
    {
        move = MoveAction.ReadValue<Vector2>();

        if (GameManager.Instance != null && GameManager.Instance.IsGameOver)
        {
            move = Vector2.zero;
            animator.SetFloat("Speed", 0);
            return;
        }

        if (move.sqrMagnitude > 0)
        {
            moveDirection = move.normalized;
        }

=======
>>>>>>> 38730236 (Added essential Unity project files)
>>>>>>> d6db4e9 (Cleaned and updated .gitattributes with essentials)
=======
>>>>>>> 4e1ec8a0a1b379c977b028a43272ce2eb29e1741
        // Component initialization
        rigidbody2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();

        // Set starting health
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        // Read movement input
        move = MoveAction.ReadValue<Vector2>();

        // Update movement direction if there is input
        if (!Mathf.Approximately(move.x, 0.0f) || !Mathf.Approximately(move.y, 0.0f))
        {
            moveDirection.Set(move.x, move.y);
            moveDirection.Normalize();
        }

        // Update animation parameters
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
        animator.SetFloat("Move X", moveDirection.x);
        animator.SetFloat("Move Y", moveDirection.y);
        animator.SetFloat("Speed", move.magnitude);

<<<<<<< HEAD
<<<<<<< HEAD
        // Handle invincibility cooldown
=======
<<<<<<< HEAD
        // Handle invincibility cooldown
=======
<<<<<<< HEAD
=======
        // Handle invincibility cooldown
>>>>>>> 4e1ec8a0a1b379c977b028a43272ce2eb29e1741
>>>>>>> 38730236 (Added essential Unity project files)
>>>>>>> d6db4e9 (Cleaned and updated .gitattributes with essentials)
=======
        // Handle invincibility cooldown
>>>>>>> 4e1ec8a0a1b379c977b028a43272ce2eb29e1741
        if (isInvincible)
        {
            damageCooldown -= Time.deltaTime;
            if (damageCooldown < 0)
                isInvincible = false;
        }
    }

<<<<<<< HEAD
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
<<<<<<< HEAD
    // Updates physics and movement
    void FixedUpdate()
    {
        Vector2 position = rigidbody2d.position + move * speed * Time.deltaTime;
        rigidbody2d.MovePosition(position);
    }

    // Change player's health and handle damage
    public void ChangeHealth(int amount)
    {
        if (amount < 0 && isInvincible)
            return;

        if (amount < 0)
        {
            isInvincible = true;
            damageCooldown = timeInvincible;
            animator.SetTrigger("Hit");

            if (bloodOverlay != null)
            {
                bloodOverlay.ShowBloodEffect();
            }
        }

        currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxHealth);
        UIHandler.instance.SetHealthValue((float)currentHealth / maxHealth);
    }

    // Launches a projectile
    void Launch(InputAction.CallbackContext context)
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        mousePosition.z = 0;
        Vector2 launchDirection = (mousePosition - transform.position).normalized;

        GameObject projectileObject = Instantiate(projectilePrefab, rigidbody2d.position + Vector2.up * 0.5f, Quaternion.identity);
        Projectile projectile = projectileObject.GetComponent<Projectile>();
        projectile.Launch(launchDirection, 300);

        animator.SetTrigger("Launch");
    }

    // Interacts with NPCs
    void FindFriend(InputAction.CallbackContext context)
    {
        RaycastHit2D hit = Physics2D.Raycast(rigidbody2d.position + Vector2.up * 0.2f, moveDirection, 1.5f, LayerMask.GetMask("NPC"));
        if (hit.collider != null)
        {
            NonPlayerCharacter character = hit.collider.GetComponent<NonPlayerCharacter>();
            if (character != null)
            {
                UIHandler.instance.DisplayDialogue();
            }
        }
    }

    // Play sound effects
=======
>>>>>>> 38730236 (Added essential Unity project files)
>>>>>>> d6db4e9 (Cleaned and updated .gitattributes with essentials)
=======
>>>>>>> 4e1ec8a0a1b379c977b028a43272ce2eb29e1741
    // FixedUpdate is called at consistent intervals for physics updates
    void FixedUpdate()
    {
        // Calculate and move to the new position
        Vector2 position = (Vector2)rigidbody2d.position + move * speed * Time.deltaTime;
        rigidbody2d.MovePosition(position);
    }

    // Method to change the player's health
    public void ChangeHealth(int amount)
    {
        // If taking damage, handle invincibility and animations
        if (amount < 0)
        {
            if (isInvincible)
                return;

            isInvincible = true;
            damageCooldown = timeInvincible;
            animator.SetTrigger("Hit");
        }

        // Update health and UI
        currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxHealth);
        UIHandler.instance.SetHealthValue(currentHealth / (float)maxHealth);
    }

    // Launch a projectile
    void Launch(InputAction.CallbackContext context)
    {
        // Instantiate and launch the projectile
        GameObject projectileObject = Instantiate(projectilePrefab, rigidbody2d.position + Vector2.up * 0.5f, Quaternion.identity);
        Projectile projectile = projectileObject.GetComponent<Projectile>();
        projectile.Launch(moveDirection, 300);

        // Trigger launch animation
        animator.SetTrigger("Launch");
    }

    // Interact with NPCs
    void FindFriend(InputAction.CallbackContext context)
    {
        // Perform a raycast to detect nearby NPCs
        RaycastHit2D hit = Physics2D.Raycast(rigidbody2d.position + Vector2.up * 0.2f, moveDirection, 1.5f, LayerMask.GetMask("NPC"));
        if (hit.collider != null)
        {
            Debug.Log("Raycast has hit the object " + hit.collider.gameObject);
        }

        // Display dialogue if an NPC is found
        NonPlayerCharacter character = hit.collider.GetComponent<NonPlayerCharacter>();
        if (character != null)
        {
            UIHandler.instance.DisplayDialogue();
        }
    }

    // Play a sound effect
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
    public void PlaySound(AudioClip clip)
    {
        audioSource.PlayOneShot(clip);
    }
}
