using UnityEngine;
using TMPro;
using System.Collections;
using UnityEngine.SceneManagement;

public class EndingDialogue : MonoBehaviour
{
    public GameObject panel;
    private string[] dialogues = {};
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Suspect1(){
        StartCoroutine(Ending1());
    }
    public void Suspect2(){
        StartCoroutine(Ending2());
    }
    public void Suspect3(){
        StartCoroutine(Ending3());
    }
    public void Suspect4(){
        StartCoroutine(Ending4());
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
