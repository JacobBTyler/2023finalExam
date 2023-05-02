using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseManager : MonoBehaviour
{

    public GameObject pauseCanvas;

    public GameObject timer;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)) {
            pauseCanvas.SetActive(true);
            timer.GetComponent<countDown>().timerRunning = false;
        }
    }

    public void resume() {
        pauseCanvas.SetActive(false);
        timer.GetComponent<countDown>().timerRunning = true;
    }


}
