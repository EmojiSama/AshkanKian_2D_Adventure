using System.Collections;
<<<<<<< HEAD
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
<<<<<<< HEAD
using UnityEngine;
using UnityEngine.UIElements;

// Manages UI elements such as health bar and NPC dialogue
public class UIHandler : MonoBehaviour
{
    // Public variables
    public float displayTime = 4.0f; // Duration to display NPC dialogue

    // Private variables
    private VisualElement m_Healthbar;        // Health bar UI element
    private VisualElement m_NonPlayerDialogue; // NPC dialogue UI element
    private float m_TimerDisplay;             // Timer to hide dialogue
=======
>>>>>>> 38730236 (Added essential Unity project files)
>>>>>>> d6db4e9 (Cleaned and updated .gitattributes with essentials)
=======
>>>>>>> 4e1ec8a0a1b379c977b028a43272ce2eb29e1741
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

// UIHandler: Manages the game's UI elements, such as health bar and NPC dialogue
public class UIHandler : MonoBehaviour
{
    // Public variables
    public float displayTime = 4.0f; // Duration for which the NPC dialogue is displayed

    // Private variables
    private VisualElement m_NonPlayerDialogue; // UI element for NPC dialogue
    private float m_TimerDisplay;             // Timer to hide dialogue after a delay
    private VisualElement m_Healthbar;        // UI element for the health bar
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

    // Singleton instance for global access
    public static UIHandler instance { get; private set; }

<<<<<<< HEAD
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
<<<<<<< HEAD
    // Initialize singleton instance
    private void Awake()
    {
        instance = this;
    }

    // Setup UI elements on start
    void Start()
    {
        UIDocument uiDocument = GetComponent<UIDocument>();

        // Initialize health bar
        m_Healthbar = uiDocument.rootVisualElement.Q<VisualElement>("HealthBar");
        SetHealthValue(1.0f); // Full health initially

        // Initialize NPC dialogue
        m_NonPlayerDialogue = uiDocument.rootVisualElement.Q<VisualElement>("NPCDialogue");
        m_NonPlayerDialogue.style.display = DisplayStyle.None; // Hidden by default

        m_TimerDisplay = -1.0f; // Timer inactive initially
    }

    // Update health bar based on percentage
    public void SetHealthValue(float percentage)
    {
        m_Healthbar.style.width = Length.Percent(100 * percentage);
    }

    // Countdown for hiding dialogue
    private void Update()
    {
        if (m_TimerDisplay > 0)
        {
            m_TimerDisplay -= Time.deltaTime;

            if (m_TimerDisplay < 0)
            {
                m_NonPlayerDialogue.style.display = DisplayStyle.None; // Hide dialogue
=======
>>>>>>> 38730236 (Added essential Unity project files)
>>>>>>> d6db4e9 (Cleaned and updated .gitattributes with essentials)
=======
>>>>>>> 4e1ec8a0a1b379c977b028a43272ce2eb29e1741
    // Awake is called when the script instance is being loaded (before Start)
    private void Awake()
    {
        // Initialize the singleton instance
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        // Get the UI document and initialize UI elements
        UIDocument uiDocument = GetComponent<UIDocument>();

        // Find and set up the health bar element
        m_Healthbar = uiDocument.rootVisualElement.Q<VisualElement>("HealthBar");
        SetHealthValue(1.0f); // Set the initial health value to full (100%)

        // Find and set up the NPC dialogue element
        m_NonPlayerDialogue = uiDocument.rootVisualElement.Q<VisualElement>("NPCDialogue");
        m_NonPlayerDialogue.style.display = DisplayStyle.None; // Hide dialogue by default

        // Initialize the dialogue display timer
        m_TimerDisplay = -1.0f;
    }

    // Updates the width of the health bar based on the player's current health percentage
    public void SetHealthValue(float percentage)
    {
        // Set the health bar's width as a percentage of its full width
        m_Healthbar.style.width = Length.Percent(100 * percentage);
    }

    // Update is called once per frame
    private void Update()
    {
        // Countdown timer to hide the NPC dialogue
        if (m_TimerDisplay > 0)
        {
            m_TimerDisplay -= Time.deltaTime;
            if (m_TimerDisplay < 0)
            {
                // Hide the dialogue when the timer expires
                m_NonPlayerDialogue.style.display = DisplayStyle.None;
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

<<<<<<< HEAD
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
<<<<<<< HEAD
    // Display NPC dialogue and reset timer
    public void DisplayDialogue()
    {
        m_NonPlayerDialogue.style.display = DisplayStyle.Flex; // Show dialogue
        m_TimerDisplay = displayTime; // Reset display timer
=======
>>>>>>> 38730236 (Added essential Unity project files)
>>>>>>> d6db4e9 (Cleaned and updated .gitattributes with essentials)
=======
>>>>>>> 4e1ec8a0a1b379c977b028a43272ce2eb29e1741
    // Displays the NPC dialogue and resets the timer
    public void DisplayDialogue()
    {
        // Show the dialogue
        m_NonPlayerDialogue.style.display = DisplayStyle.Flex;

        // Reset the timer to keep the dialogue displayed
        m_TimerDisplay = displayTime;
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
