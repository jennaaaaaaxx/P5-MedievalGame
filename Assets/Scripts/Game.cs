using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    // Clicker stuff here
    [Header("Money")]
    public Text scoreText;
    public float currentScore;
    public float hitPower;
    public float scoreIncreasedPerSecond;
    public float x;

    // Shop
    [Header("Shop")]

    [Header("House")]
    public int shop1Price;
    public Text shop1Text;
    [Header("Tavern")]
    public int shop2Price;
    public Text shop2Text;
    [Header("Stable")]
    public int shop3Price;
    public Text shop3Text;
    [Header("Bakery")]
    public int shop4Price;
    public Text shop4Text;
    [Header("Church")]
    public int shop5Price;
    public Text shop5Text;

    // Amounts
    [Header("Amounts")]

    [Header("House")]
    public int amount1;
    public Text amount1Text;
    public float amount1Profit;
    [Header("Tavern")]
    public int amount2;
    public Text amount2Text;
    public float amount2Profit;
    [Header("Stable")]
    public int amount3;
    public Text amount3Text;
    public float amount3Profit;
    [Header("Bakery")]
    public int amount4;
    public Text amount4Text;
    public float amount4Profit;
    [Header("Church")]
    public int amount5;
    public Text amount5Text;
    public float amount5Profit;


    void Start()
    {
        // Clicker
        currentScore = 0;
        hitPower = 1;
        scoreIncreasedPerSecond = 1;
        x= 0f;
    }

 
    void Update()
    {

        // Clicker
        scoreText.text = "£" + (int)currentScore;
        scoreIncreasedPerSecond = x * Time.deltaTime;
        currentScore = currentScore + scoreIncreasedPerSecond;

        // Shop
        shop1Text.text = "House: " + shop1Price + " £";
        shop2Text.text = "Tavern: " + shop2Price + " £";
        shop3Text.text = "Stable: " + shop3Price + " £";
        shop4Text.text = "Bakery: " + shop4Price + " £";
        shop5Text.text = "Church: " + shop5Price + " £";

        // Amount
        amount1Text.text = amount1 + " Houses: " + amount1Profit + "£/s";
        amount2Text.text = amount2 + " Taverns: " + amount2Profit + "£/s";
        amount3Text.text = amount3 + " Stables: " + amount3Profit + "£/s";
        amount4Text.text = amount4 + " Bakeries: " + amount4Profit + "£/s";
        amount5Text.text = amount5 + " Churches: " + amount5Profit + "£/s";
    }

    // Hit
    public void Hit()
    {
        currentScore += hitPower;
    }

    // Shop
    public void Shop1()
    {
        if(currentScore >= shop1Price)
        {
            currentScore -= shop1Price;
            amount1 += 1;
            amount1Profit += 0.3f;
            x += 0.3f;
            shop1Price = (int)(shop1Price * 1.2f);
        }
    }
    public void Shop2()
    {
        if (currentScore >= shop2Price)
        {
            currentScore -= shop2Price;
            amount2 += 1;
            amount2Profit += 1f;
            x += 1;
            shop2Price = (int)(shop2Price * 1.2f);
        }
    }
    public void Shop3()
    {
        if (currentScore >= shop3Price)
        {
            currentScore -= shop3Price;
            amount3 += 1;
            amount3Profit += 4f;
            x += 4;
            shop3Price = (int)(shop3Price * 1.2f);
        }
    }
    public void Shop4()
    {
        if (currentScore >= shop4Price)
        {
            currentScore -= shop4Price;
            amount4 += 1;
            amount4Profit += 20f;
            x += 20;
            shop4Price = (int)(shop4Price * 1.2f);
        }
    }
    public void Shop5()
    {
        if (currentScore >= shop5Price)
        {
            currentScore -= shop5Price;
            amount5 += 1;
            amount5Profit += 120f;
            x += 120;
            shop5Price = (int)(shop5Price * 1.2f);
        }
    }
}
