using UnityEngine;
using TMPro;
using System.Collections;
using UnityEngine.SceneManagement;

public class EndingDialogue : MonoBehaviour
{
    public GameObject panel;
    public GameObject continuePrompt;
    private string[] EndDialogues1 = {"*Your intuition was wrong and has led you astray.*", "Ain't me man, if anything you should check out my sibling more."};
    private string[] EndDialogues2 = {"*Your intuition was wrong and has led you astray.*", "How could you think it was me!? Giff meant everything to me. I'll never be the same..." };
    private string[] EndDialogues3 = {"*Your intuition was wrong and has led you astray.*", "Nope, but if it was my precious Miku I would have made sure to have found the culprit faster than you"};
    private string[] EndDialogues4 = {"*Your intuition was correct! You have found the true murderer!*", "Giff didnt deserve to be Valedictorian! It should have been me! Not him! Me!"};
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(StartEnding());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Suspect1(){
        continuePrompt.SetActive(true);
        StartCoroutine(Ending1());
    }
    public void Suspect2(){
        continuePrompt.SetActive(true);
        StartCoroutine(Ending2());
    }
    public void Suspect3(){
        continuePrompt.SetActive(true);
        StartCoroutine(Ending3());
    }
    public void Suspect4(){
        continuePrompt.SetActive(true);
        StartCoroutine(Ending4());
    }
    private IEnumerator Ending1(){
        RectTransform rectTransform = panel.GetComponent<RectTransform>();
        rectTransform.anchoredPosition = new Vector2(0, 0);

        panel.SetActive(true);

        TextMeshProUGUI text = panel.GetComponentInChildren<TextMeshProUGUI>();
        foreach(string dialogue in EndDialogues1){
            text.text = dialogue;
            yield return WaitForKeyPress(KeyCode.Space);
        }

        text.text = "";
        SceneManager.LoadScene(0);
    }
    private IEnumerator Ending2(){
        RectTransform rectTransform = panel.GetComponent<RectTransform>();
        rectTransform.anchoredPosition = new Vector2(0, 0);

        panel.SetActive(true);

        TextMeshProUGUI text = panel.GetComponentInChildren<TextMeshProUGUI>();
        foreach(string dialogue in EndDialogues2){
            text.text = dialogue;
            yield return WaitForKeyPress(KeyCode.Space);
        }

        text.text = "";
        SceneManager.LoadScene(0);
    }
    private IEnumerator Ending3(){
        RectTransform rectTransform = panel.GetComponent<RectTransform>();
        rectTransform.anchoredPosition = new Vector2(0, 0);

        panel.SetActive(true);

        TextMeshProUGUI text = panel.GetComponentInChildren<TextMeshProUGUI>();
        foreach(string dialogue in EndDialogues3){
            text.text = dialogue;
            yield return WaitForKeyPress(KeyCode.Space);
        }

        text.text = "";
        SceneManager.LoadScene(0);
    }
    private IEnumerator Ending4(){
        RectTransform rectTransform = panel.GetComponent<RectTransform>();
        rectTransform.anchoredPosition = new Vector2(0, 0);

        panel.SetActive(true);

        TextMeshProUGUI text = panel.GetComponentInChildren<TextMeshProUGUI>();
        foreach(string dialogue in EndDialogues4){
            text.text = dialogue;
            yield return WaitForKeyPress(KeyCode.Space);
        }

        text.text = "";
        SceneManager.LoadScene(0);
    }

    private IEnumerator StartEnding(){
        RectTransform rectTransform = panel.GetComponent<RectTransform>();
        rectTransform.anchoredPosition = new Vector2(0, 0);

        panel.SetActive(true);

        TextMeshProUGUI text = panel.GetComponentInChildren<TextMeshProUGUI>();
        continuePrompt.SetActive(true);
        
        text.text = "Here are our suspects: George, Manny, Baka, and Calculus";
        yield return WaitForKeyPress(KeyCode.Space);
        
        text.text = "George: 9 year old brother of Calculus. Hates gifs. D student. \nEvidence against: Yellow Hat.";
        yield return WaitForKeyPress(KeyCode.Space);
        
        text.text = "Manny: Giff's boyfriend. Ugly fight recently. A crime of passion? \nEvidence against: Torn up love letter found on body";
        yield return WaitForKeyPress(KeyCode.Space);
        
        text.text = "Baka: Found near the scene of the crime. Just kinda weird, man. Weeb. Hasnt stopped carrying that body pillow... \nEvidence against: kinda sussy";
        yield return WaitForKeyPress(KeyCode.Space);
        
        text.text = "Calculus: Jealous of Giff's math skills. Salutatorian at Giff's school. \nEvidence against: Calculator";
        yield return WaitForKeyPress(KeyCode.Space);

        text.text = "*After gathering all of the evidence, you are ready to accuse one of the other suspects.\nWho will you convict in the murder of Giff Tanner?*";
        continuePrompt.SetActive(false);
        yield return null;
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
