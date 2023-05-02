using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{

    public static string userName;

    public static int lives;

    public static int points;

    public static float timer;

    public static int[] topScores = new int[10];

    public Dropdown liveDropdown;

    public Slider timerSlider;

    public InputField nameInput;

    
    // Start is called before the first frame update
    void Start()
    {
        userName = "default";
        lives = 0;
        points = 0;
        timer = 90.0f;
    
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(timerSlider.value);
        Debug.Log(lives);
    }

    public void updateScores() {
        
    }

    public void initialize() {
        Debug.Log(nameInput.GetComponent<InputField>().text);
        userName = nameInput.GetComponent<InputField>().text;
        lives = liveDropdown.value;
        timer = timerSlider.value;
        Debug.Log(timer);
        Debug.Log(timerSlider.value);
    }
}
