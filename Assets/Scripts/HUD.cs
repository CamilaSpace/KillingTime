using UnityEngine;

public class HUD : MonoBehaviour
{
    public Interact inventory;
    private string[] items;
    public GameObject[] objects;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        items = new string[] {"Calculator", "PartyHat", "TornLoveLetter"};
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < items.Length; i++){
            if(inventory.evidence.Contains(items[i])){
                objects[i].SetActive(true);
            }
        }
    }
}
