using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class timer_script : MonoBehaviour
{
    public Text timer_text;
    public FloatValue timerValue;
    public bool timerIsRunning = false;

    // Start is called before the first frame update
    void Start()
    {
        timerIsRunning = true;
    }

    // Update is called once per frame
    public void Update()
    {
        if (timerValue.runtimeValue > 0){
            timerValue.runtimeValue -= Time.deltaTime;
            float minutes = Mathf.FloorToInt(timerValue.runtimeValue / 60);  
            float seconds = Mathf.FloorToInt(timerValue.runtimeValue % 60);
            timer_text.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        } else {
            Debug.Log("Time's up!");
            timerIsRunning = false;
            SceneManager.LoadScene("Gameover");
        }
    }
}
