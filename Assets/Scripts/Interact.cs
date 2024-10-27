using UnityEngine;
using System.Collections.Generic;

public class Interact : MonoBehaviour
{
    public GameObject gradCordIcon;
    public GameObject knifeIcon;
    public GameObject bTestIcon;
    public GameObject tornLoveLetterIcon;
    public GameObject partyHatIcon;
    public GameObject calculatorIcon;
    public List<string> evidence = new List<string>();

    void Start() 
    {
        // Initially hide all the icons
        gradCordIcon.SetActive(false);
        knifeIcon.SetActive(false);
        bTestIcon.SetActive(false);
        tornLoveLetterIcon.SetActive(false);
        partyHatIcon.SetActive(false);
        calculatorIcon.SetActive(false);
    }

    void Update()
    {
        // Show the icon when the respective key is pressed
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            gradCordIcon.SetActive(true);
            evidence.Add("GradCord");
            print("Grad Cord added to evidence");
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            knifeIcon.SetActive(true);
            evidence.Add("Knife");
            print("Knife added to evidence");
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            bTestIcon.SetActive(true);
            evidence.Add("B Test");
            print("B Test added to evidence");
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            tornLoveLetterIcon.SetActive(true);
            evidence.Add("Torn Love Letter");
            print("Torn Love Letter added to evidence");
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            partyHatIcon.SetActive(true);
            evidence.Add("Party Hat");
            print("Party Hat added to evidence");
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            calculatorIcon.SetActive(true);
            evidence.Add("Calculator");
            print("Calculator added to evidence");
        }
    }

    // Commenting out the part that requires the player to be near the item
    /*
    private void OnTriggerEnter(Collider other)
    {
        triggerName = other.name;
    }

    private void OnTriggerExit(Collider other)
    {
        triggerName = "";
    }
    */
}
