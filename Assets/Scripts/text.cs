using UnityEngine;
using TMPro;

public class RandomTextPosition : MonoBehaviour
{
    public GameObject panel;  // Assign your Panel object here

    void Start()
    {
        InvokeRepeating("ShowRandomText", 1.0f, 3.0f); // Call every 3 seconds
    }

    // This method will set the panel (and the text inside it) to a random position
    void ShowRandomText()
    {
        // Set a random position for the panel within the screen bounds
        RectTransform rectTransform = panel.GetComponent<RectTransform>();
        rectTransform.anchoredPosition = new Vector2(Random.Range(-400f, 400f), Random.Range(-200f, 200f));

        // Enable the panel if it's disabled
        panel.SetActive(true);

        // Optionally, you can still change the text content dynamically if needed
        TextMeshProUGUI text = panel.GetComponentInChildren<TextMeshProUGUI>();
        string[] randomMessages = { "Hi!", "Evidence found!", "Penelope thinks...", "Clue discovered!" };
        text.text = randomMessages[Random.Range(0, randomMessages.Length)];

        // Hide the panel after a short delay (optional)
        Invoke("HidePanel", 2.0f); // Hide after 2 seconds
    }

    void HidePanel()
    {
        panel.SetActive(false);
    }
}
