using UnityEngine;

public class ChooseSuspect : MonoBehaviour
{

    public void AccuseSuspect(int suspectNum){
        if(suspectNum == 1){
            print("Incorrect");
        }
        if(suspectNum == 2){
            print("Incorrect");
        }
        if(suspectNum == 3){
            print("Correct");
        }
        if(suspectNum == 4){
            print("Incorrect");
        }
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
