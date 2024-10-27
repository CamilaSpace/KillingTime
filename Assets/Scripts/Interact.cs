using UnityEngine;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class Interact : MonoBehaviour
{
    // public GameObject gradCordIcon;
    // public GameObject knifeIcon;
    // public GameObject bTestIcon;
    // public GameObject tornLoveLetterIcon;
    // public GameObject partyHatIcon;
    // public GameObject calculatorIcon;
    public List<string> evidence = new List<string>();
    private string triggerName;

    [Header("letter")]
    public GameObject tornLoveLetterIcon;

    [Header("hat")]
    public GameObject partyHatIcon;

    [Header("calculator")]
    public GameObject calculatorIcon;

    void Start() 
    {
        // Initially hide all the icons
        // gradCordIcon.SetActive(false);
        // knifeIcon.SetActive(false);
        // bTestIcon.SetActive(false);
        tornLoveLetterIcon.SetActive(false);
        partyHatIcon.SetActive(false);
        calculatorIcon.SetActive(false);
    }

    void Update()
    {
        if(evidence.Count == 2)
        {
                print("Work pls");
                SceneManager.LoadScene(3);
        }

        if(Input.GetKeyDown(KeyCode.Space)){
        // Show the icon when the respective key is pressed
            if (triggerName == "Torn Love Letter")
            {
                //tornLoveLetterIcon.SetActive(true);
                evidence.Add("Torn Love Letter");
                tornLoveLetterIcon.SetActive(true);
                print("Torn Love Letter added to evidence");
            }
            if (triggerName == "Party Hat")
            {
                //partyHatIcon.SetActive(true);
                evidence.Add("Party Hat");
                partyHatIcon.SetActive(true);
                print("Party Hat added to evidence");
            }
            if (triggerName == "Calculator")
            {
                //calculatorIcon.SetActive(true);
                evidence.Add("Calculator");
                calculatorIcon.SetActive(true);
                print("Calculator added to evidence");
            }

            
        }
        
    }

    // Commenting out the part that requires the player to be near the item
    
    private void OnTriggerEnter(Collider other)
    {
        triggerName = other.name;
    }

    private void OnTriggerExit(Collider other)
    {
        triggerName = "";
    }
    
}
