using UnityEngine;

public class BlankUI : MonoBehaviour
{
    public GameObject panelToShow;  // Assign the UI panel in the Inspector

    // This method will be triggered when the button is clicked
    public void ShowUIPanel()
    {
        if (panelToShow != null)
        {
            panelToShow.SetActive(true);  // Make the panel visible
        }
    }
}
