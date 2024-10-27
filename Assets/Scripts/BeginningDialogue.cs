using UnityEngine;
using TMPro;
using System.Collections;
using UnityEngine.SceneManagement;

public class BeginningDialogue : MonoBehaviour
{
    public GameObject panel;
    public GameObject continuePrompt;
    private string[] dialogues = { "Stranger:\nHey! Hey you!", "Stranger:\nYou've gotta help me out here.", "Martina McFlew:\nMy name is Martina McFlew, and I'm on trial for the murder of Giff Tanner, but I'm innocent! Please believe me.",
                                "Martina McFlew:\nYou...\nYou do believe me!?", "Martina McFlew:\nThat's great!", "Martina McFlew:\nThat means that I can trust you to help prove my innocence, right?", "Martina McFlew:\nSince you're a private investigator, it'll cost me huh?",
                                "Martina McFlew:\nHow about this: Take this pen.", "*Confused, you take the mysterious pen from Martina.*", "Martina McFlew:\nThat pen will let you time travel to both the past and back to the future.",
                                "Martina McFlew:\nConsider it payment, but also use it to go back in time to prove my innocence and convict the true murderer.", "Martina McFlew:\nI'll be seeing you. By the way, it'll deguise you too, so don't be alarmed.", "Martina McFlew:\nGood luck. My life depends on your success.", "*You head out to discover the truth behind the murder of Giff Tanner.*"};

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(DisplayDialogue());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator DisplayDialogue(){
        RectTransform rectTransform = panel.GetComponent<RectTransform>();
        rectTransform.anchoredPosition = new Vector2(0, 0);

        panel.SetActive(true);

        TextMeshProUGUI text = panel.GetComponentInChildren<TextMeshProUGUI>();
        foreach(string dialogue in dialogues){
            text.text = dialogue;
            yield return WaitForKeyPress(KeyCode.Space);
        }

        text.text = "";
        SceneManager.LoadScene(2);
    }

    private IEnumerator WaitForKeyPress(KeyCode key){
        bool done = false;
        while(!done){
            if(Input.GetKeyDown(key)){
                done = true;
            }
            yield return null;
        }
    }
}
