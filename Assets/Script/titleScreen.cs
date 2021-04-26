using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class titleScreen : MonoBehaviour
{
    public FloatValue currentHealth;
    public FloatValue currentSanity;
    public FloatValue currentMoney;
    public Signal healthSignal;
    public Signal sanitySignal;
    public Signal moneySignal;
    public VectorValue startingPosition;
    public bool firstgame = true;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth.resetFloatValue();
        currentMoney.resetFloatValue();
        currentSanity.resetFloatValue();
        startingPosition.resetVectorValue();
        /*healthSignal.Raise();
        sanitySignal.Raise();
        moneySignal.Raise();*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NewGame(){
        //if (firstgame){
            //firstgame = false;
            SceneManager.LoadScene("tempStreet");
        /*} else {
            for (int i = 1; i < 8; i++){
                SceneManager.UnloadSceneAsync(i);
            }
            SceneManager.LoadScene("tempStreet");
        }
        firstgame = false;*/
    }

    public void quitGame(){
        Application.Quit();
    }
}
