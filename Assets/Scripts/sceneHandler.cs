using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneHandler : MonoBehaviour
{

    public GameObject manager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void startGame() {
        Debug.Log("calling initialize");
        manager.GetComponent<GameManager>().initialize();
        SceneManager.LoadScene("2Game");
    }

    public void stopGame() {
        //manager.GetComponent<GameManager>().updateScores();
        SceneManager.LoadScene("3Exit");
    }

    public void replayGame() {
        SceneManager.LoadScene("1Intro");
    }

    public void exitGame() {
        Debug.Log("Quitting game!");
    }
}
