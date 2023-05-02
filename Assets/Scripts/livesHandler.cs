using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class livesHandler : MonoBehaviour
{
    // Start is called before the first frame update
    public Text livesDisplay;

    public GameObject manager;

    void Start() {
        Debug.Log("setting starting lives to: " + GameManager.lives);
        livesDisplay.text = GameManager.lives.ToString();
    }

    public void increaseLives() {
        GameManager.lives+=1;
        livesDisplay.text = GameManager.lives.ToString();
    }

    public void decreaseLives() {
        GameManager.lives-=1;
        livesDisplay.text = GameManager.lives.ToString();
    }
}
