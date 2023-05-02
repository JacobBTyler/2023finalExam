using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pointsManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Text pointsDisplay;

    public GameObject manager;

    void start() {
        pointsDisplay.text = GameManager.points.ToString();
    }

    public void increasePoints() {
        GameManager.points+=1;
        pointsDisplay.text = GameManager.points.ToString();
    }

    public void decreasePoints() {
        GameManager.points-=1;
        pointsDisplay.text = GameManager.points.ToString();
    }
}
