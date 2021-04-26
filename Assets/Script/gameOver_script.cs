using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameOver_script : MonoBehaviour
{
    //public Text contactCountMessage;
    // PLEASE ADD HERE
    // Start is called before the first frame update
    void Start()
    {
        //contactCountMessage.setText("You have "+ count + "contacts.")
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void toTitleScreen(){
        SceneManager.LoadScene("title_screen");
    }
}
