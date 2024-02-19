using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    // Clicker stuff here
    public Text scoreText;
    public float currentScore;
    public float hitPower;
    public float scoreIncreasedPerSecond;
    public float x;

    // Start is called before the first frame update
    void Start()
    {
        // Clicker
        currentScore = 0;
        hitPower = 1;
        scoreIncreasedPerSecond = 1;
        x= 0f;
    }

    // Update is called once per frame
    void Update()
    {

        // Clicker
        scoreText.text = "£" + (int)currentScore;
        scoreIncreasedPerSecond = x * Time.deltaTime;
        currentScore = currentScore + scoreIncreasedPerSecond;

    }

    // Hit
    public void Hit()
    {
        currentScore += hitPower;
    }
}
