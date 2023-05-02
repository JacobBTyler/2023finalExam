using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class nameHandler : MonoBehaviour
{
    public Text nameDisplay;

    //public GameObject manager;

    // Start is called before the first frame update
    void Start()
    {
        nameDisplay.text = GameManager.userName;
    }

}