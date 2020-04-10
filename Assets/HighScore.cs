using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScore : MonoBehaviour
{
    static public int score = 1000;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Awake()
    {
        // if the ApplePicker HighScore already exists, read it
        if (PlayerPrefs.HasKey("ApplePickerHighScore"))
        {
            score = PlayerPrefs.GetInt("ApplePickerHighScore");
        }
        PlayerPrefs.SetInt("ApplePickerHighScore", score);
    }

    // Update is called once per frame
    void Update()
    {
        // Find a reference to ScoreCounter GameObject
        // GameObject scoreGo = GameObject.Find("HighScore");
        // get the GUIText component of the GameObject
        TextMesh scoreGT = this.GetComponent<TextMesh>();
        // Set the starting number of points to 0
        scoreGT.text = "High Score: " + score;
        if(score > PlayerPrefs.GetInt("ApplePickerHighScore"))
        {
            PlayerPrefs.SetInt("ApplePickerHighScore", score);
        }
    }
}
