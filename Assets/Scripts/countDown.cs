using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class countDown : MonoBehaviour
{

    public Text timerDisplay;

    public GameObject manager;

    public GameObject scene;

    public bool timerRunning;

    // Start is called before the first frame update
    void Start()
    {
        timerDisplay.text = GameManager.timer.ToString();
        timerRunning = true;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(GameManager.timer);
        if(timerRunning) {
            if(GameManager.timer > 0) {
                GameManager.timer -= Time.deltaTime;
                timerDisplay.GetComponent<Text>().text = GameManager.timer + " Seconds Remaining!";
            }
            else {
                GameManager.timer = 0;
                timerRunning = false;
                scene.GetComponent<sceneHandler>().stopGame();
            } 
        }
        
    }
}
