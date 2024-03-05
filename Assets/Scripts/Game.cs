using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;

// Everything scripting-wise done, add more buildings, upgrades, achievements >_<

public class Game : MonoBehaviour
{
    // Clicker
    [Header("Clicker")]
    public Text scoreText;
    public float currentScore;
    public float totalScore;
    public static float hitPower; // Static
    public float scoreIncreasedPerSecond;

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
    public int amount1Upgrade;
    public float amount1Profit;
    [Header("Tavern")]
    public int amount2;
    public Text amount2Text;
    public int amount2Upgrade;
    public float amount2Profit;
    [Header("Stable")]
    public int amount3;
    public Text amount3Text;
    public int amount3Upgrade;
    public float amount3Profit;
    [Header("Bakery")]
    public int amount4;
    public Text amount4Text;
    public int amount4Upgrade;
    public float amount4Profit;
    [Header("Church")]
    public int amount5;
    public Text amount5Text;
    public int amount5Upgrade;
    public float amount5Profit;

    // Upgrades
    [Header("Upgrades")]

    [Header("Non-building Upgrades")]
    public int allUpgradePrice;
    public Text allUpgradeText;
    public int clickUpgradePrice;
    public Text clickUpgradeText;
    [Header("Buildings 1-5 Upgrades")]
    public int houseUpgradePrice;
    public Text houseUpgradeText;
    public int tavernUpgradePrice;
    public Text tavernUpgradeText;
    public int stableUpgradePrice;
    public Text stableUpgradeText;
    public int bakeryUpgradePrice;
    public Text bakeryUpgradeText;
    public int churchUpgradePrice;
    public Text churchUpgradeText;

    // Achievements
    [Header("Achievements")]

    [Header("Achievements")]
    public bool achievementScore;
    public bool achievementHouse;
    public bool achievementTavern;
    public bool achievementStable;
    public bool achievementBakery;
    public bool achievementChurch;
    [Header("Achievement Images")]
    public UnityEngine.UI.Image image1;
    public UnityEngine.UI.Image image2;
    public UnityEngine.UI.Image image3;
    public UnityEngine.UI.Image image4;
    public UnityEngine.UI.Image image5;
    public UnityEngine.UI.Image image6;

    // Level system
    [Header("Level System")]
    public float level;
    public int xp;
    public int xpToNextLevel;
    public float levelMultiplier;
    public Text levelText;
    public Text xpToNextLevelText;
    public Text levelMultiplierText;

    // Random events
    [Header("Random Events")]
    public bool eventIsNow;
    public GameObject goldCoin;

    // Hit
    [Header("Hit Effect")]
    public GameObject plusObject;

    void Start()
    {
        // Clicker
        currentScore = 0;
        totalScore = 0;
        hitPower = 1;
        scoreIncreasedPerSecond = 1;

        // Setting variables before load
        shop1Price = 25;
        shop2Price = 100;
        shop3Price = 500;
        shop4Price = 3000;
        shop5Price = 21000;
        amount1 = 0;
        amount1Profit = 0.3f;
        amount2 = 0;
        amount2Profit = 1f;
        amount3 = 0;
        amount3Profit = 4f;
        amount4 = 0;
        amount4Profit = 20f;
        amount5 = 0;
        amount5Profit = 120f;
        level = 1;
        xp = 0;
        xpToNextLevel = 50;

        // Reset Lines
        // PlayerPrefs.DeleteAll();

        // Load
        currentScore = PlayerPrefs.GetInt("currentScore", 0);
        totalScore = PlayerPrefs.GetInt("totalScore", 0);
        hitPower = PlayerPrefs.GetInt("hitPower", 1);

        shop1Price = PlayerPrefs.GetInt("shop1Price", 25);
        shop2Price = PlayerPrefs.GetInt("shop2Price", 100);
        shop3Price = PlayerPrefs.GetInt("shop3Price", 500);
        shop4Price = PlayerPrefs.GetInt("shop4Price", 3000);
        shop5Price = PlayerPrefs.GetInt("shop5Price", 21000);
        amount1 = PlayerPrefs.GetInt("amount1", 0);
        amount1Profit = PlayerPrefs.GetFloat("amount1Profit", 0);
        amount1Upgrade = PlayerPrefs.GetInt("amount1Upgrade", 1);
        amount2 = PlayerPrefs.GetInt("amount2", 0);
        amount2Profit = PlayerPrefs.GetFloat("amount2Profit", 0);
        amount2Upgrade = PlayerPrefs.GetInt("amount2Upgrade", 1);
        amount3 = PlayerPrefs.GetInt("amount3", 0);
        amount3Profit = PlayerPrefs.GetFloat("amount3Profit", 0);
        amount3Upgrade = PlayerPrefs.GetInt("amount3Upgrade", 1);
        amount4 = PlayerPrefs.GetInt("amount4", 0);
        amount4Profit = PlayerPrefs.GetFloat("amount4Profit", 0);
        amount4Upgrade = PlayerPrefs.GetInt("amount4Upgrade", 1);
        amount5 = PlayerPrefs.GetInt("amount5", 0);
        amount5Profit = PlayerPrefs.GetFloat("amount5Profit", 0);
        amount5Upgrade = PlayerPrefs.GetInt("amount5Upgrade", 1);
        clickUpgradePrice = PlayerPrefs.GetInt("clickUpgradePrice", 100);
        allUpgradePrice = PlayerPrefs.GetInt("allUpgradePrice", 2500);
        houseUpgradePrice = PlayerPrefs.GetInt("houseUpgradePrice", 250);
        tavernUpgradePrice = PlayerPrefs.GetInt("tavernUpgradePrice", 1000);
        stableUpgradePrice = PlayerPrefs.GetInt("stableUpgradePrice", 5000);
        bakeryUpgradePrice = PlayerPrefs.GetInt("bakeryUpgradePrice", 30000);
        churchUpgradePrice = PlayerPrefs.GetInt("churchUpgradePrice", 210000);
        achievementScore = PlayerPrefs.Equals("achievementScore", false);
        achievementHouse = PlayerPrefs.Equals("achievementHouse", false);
        achievementTavern = PlayerPrefs.Equals("achievementTavern", false);
        achievementStable = PlayerPrefs.Equals("achievementStable", false);
        achievementBakery = PlayerPrefs.Equals("achievementBakery", false);
        achievementChurch = PlayerPrefs.Equals("achievementChurch", false);
        level = PlayerPrefs.GetInt("level", 1);
        xp = PlayerPrefs.GetInt("xp", 0);
        xpToNextLevel = PlayerPrefs.GetInt("xpToNextLevel", 50);
    }

 
    void Update()
    {
       
        // Clicker
        scoreText.text = "£" + (int)currentScore;
        scoreIncreasedPerSecond = (amount1Profit + amount2Profit + amount3Profit + amount4Profit + amount5Profit) * levelMultiplier * Time.deltaTime;
        currentScore = currentScore + scoreIncreasedPerSecond;
        totalScore = totalScore + scoreIncreasedPerSecond;

        // Shop
        shop1Text.text = "House: £" + shop1Price;
        shop2Text.text = "Tavern: £" + shop2Price;
        shop3Text.text = "Stable: £" + shop3Price;
        shop4Text.text = "Bakery: £" + shop4Price;
        shop5Text.text = "Church: £" + shop5Price;

        // Amount
        amount1Text.text = amount1 + " Houses: £" + (amount1Profit * levelMultiplier) + "/s";
        amount2Text.text = amount2 + " Taverns: £" + (amount2Profit * levelMultiplier) + "/s";
        amount3Text.text = amount3 + " Stables: £" + (amount3Profit * levelMultiplier) + "/s";
        amount4Text.text = amount4 + " Bakeries: £" + (amount4Profit * levelMultiplier) + "/s";
        amount5Text.text = amount5 + " Churches: £" + (amount5Profit * levelMultiplier) + "/s";

        // Upgrades
        clickUpgradeText.text = "Cost: £" + clickUpgradePrice;
        allUpgradeText.text = "Cost: £" + allUpgradePrice;
        // Buildings 1-5 Upgrades
        houseUpgradeText.text = "Cost: £" + houseUpgradePrice;
        tavernUpgradeText.text = "Cost: £" + tavernUpgradePrice;
        stableUpgradeText.text = "Cost: £" + stableUpgradePrice;
        bakeryUpgradeText.text = "Cost: £" + bakeryUpgradePrice;
        churchUpgradeText.text = "Cost: £" + churchUpgradePrice;

        // Save
        PlayerPrefs.SetInt("currentScore", (int)currentScore);
        PlayerPrefs.SetInt("totalScore", (int)totalScore);
        PlayerPrefs.SetInt("hitPower", (int)hitPower);

        PlayerPrefs.SetInt("shop1Price", (int)shop1Price);
        PlayerPrefs.SetInt("shop2Price", (int)shop2Price);
        PlayerPrefs.SetInt("shop3Price", (int)shop3Price);
        PlayerPrefs.SetInt("shop4Price", (int)shop4Price);
        PlayerPrefs.SetInt("shop5Price", (int)shop5Price);
        PlayerPrefs.SetInt("amount1", (int)amount1);
        PlayerPrefs.SetFloat("amount1Profit", (float)amount1Profit);
        PlayerPrefs.SetInt("amount1Upgrade", (int)amount1Upgrade);
        PlayerPrefs.SetInt("amount2", (int)amount2);
        PlayerPrefs.SetFloat("amount2Profit", (float)amount2Profit);
        PlayerPrefs.SetInt("amount2Upgrade", (int)amount2Upgrade);
        PlayerPrefs.SetInt("amount3", (int)amount3);
        PlayerPrefs.SetFloat("amount3Profit", (float)amount3Profit);
        PlayerPrefs.SetInt("amount3Upgrade", (int)amount3Upgrade);
        PlayerPrefs.SetInt("amount4", (int)amount4);
        PlayerPrefs.SetFloat("amount4Profit", (float)amount4Profit);
        PlayerPrefs.SetInt("amount4Upgrade", (int)amount4Upgrade);
        PlayerPrefs.SetInt("amount5", (int)amount5);
        PlayerPrefs.SetFloat("amount5Profit", (float)amount5Profit);
        PlayerPrefs.SetInt("amount5Upgrade", (int)amount5Upgrade);
        PlayerPrefs.SetInt("clickUpgradePrice", (int)clickUpgradePrice);
        PlayerPrefs.SetInt("allUpgradePrice", (int)allUpgradePrice);
        PlayerPrefs.SetInt("houseUpgradePrice", (int)houseUpgradePrice);
        PlayerPrefs.SetInt("tavernUpgradePrice", (int)tavernUpgradePrice);
        PlayerPrefs.SetInt("stableUpgradePrice", (int)stableUpgradePrice);
        PlayerPrefs.SetInt("bakeryUpgradePrice", (int)bakeryUpgradePrice);
        PlayerPrefs.SetInt("churchUpgradePrice", (int)churchUpgradePrice);
        PlayerPrefs.Equals("achievementScore", (bool)achievementScore);
        PlayerPrefs.Equals("achievementHouse", (bool)achievementHouse);
        PlayerPrefs.Equals("achievementTavern", (bool)achievementTavern);
        PlayerPrefs.Equals("achievementStable", (bool)achievementStable);
        PlayerPrefs.Equals("achievementBakery", (bool)achievementBakery);
        PlayerPrefs.Equals("achievementChurch", (bool)achievementChurch);
        PlayerPrefs.SetInt("level", (int)level);
        PlayerPrefs.SetInt("xp", (int)xp);
        PlayerPrefs.SetInt("xpToNextLevel", (int)xpToNextLevel);

        // Achievements

        // Total Earnt Achievements
        if (totalScore >= 1000)
        {
            achievementScore = true;
        }
        
        if (achievementScore == true)
        {
            image1.color = new Color(0f, 1f, 0.315f, 1f);
        }
        else
        {
            image1.color = new Color(1f, 0.1f, 0f, 1f);
        }
        // House Achievements
        if (amount1 >= 10)
        {
            achievementHouse = true;
        }

        if (achievementHouse == true)
        {
            image2.color = new Color(0f, 1f, 0.315f, 1f);
        }
        else
        {
            image2.color = new Color(1f, 0.1f, 0f, 1f);
        }
        // Tavern Achievements
        if (amount2 >= 10)
        {
            achievementTavern = true;
        }
        
        if (achievementTavern == true)
        {
            image3.color = new Color(0f, 1f, 0.315f, 1f);
        }
        else
        {
            image3.color = new Color(1f, 0.1f, 0f, 1f);
        }
        // Stable Achievements
        if (amount3 >= 10)
        {
            achievementStable = true;
        }
        
        if (achievementStable == true)
        {
            image4.color = new Color(0f, 1f, 0.315f, 1f);
        }
        else
        {
            image4.color = new Color(1f, 0.1f, 0f, 1f);
        }
        // Bakery Achievements
        if (amount4 >= 10)
        {
            achievementBakery = true;
        }
        
        if (achievementBakery == true)
        {
            image5.color = new Color(0f, 1f, 0.315f, 1f);
        }
        else
        {
            image5.color = new Color(1f, 0.1f, 0f, 1f);
        }
        // Church Achievements
        if (amount5 >= 10)
        {
            achievementChurch = true;
        }
        
        if (achievementChurch == true)
        {
            image6.color = new Color(0f, 1f, 0.315f, 1f);
        }
        else
        {
            image6.color = new Color(1f, 0.1f, 0f, 1f);
        }

        // Level
        if (xp >= xpToNextLevel)
        {
            level++;
            xp = 0;
            xpToNextLevel *= 2;
        }

        levelText.text = "Level " + level;
        xpToNextLevelText.text = "Xp to next level: " + (xpToNextLevel - xp);
        levelMultiplier = (1f + ((level - 1f) / 10f));
        levelMultiplierText.text = "Level multiplier: " + levelMultiplier + "X";

        // Random Events
        if(eventIsNow == false && goldCoin.active == true)
        {
            goldCoin.SetActive(false);
            goldCoin.transform.position = new Vector3(UnityEngine.Random.Range(0, 400), UnityEngine.Random.Range(0, 400), 0);
            StartCoroutine(WaitForEvent());
        }
        
        if(eventIsNow == true && goldCoin.active == false)
        {
            goldCoin.transform.position = new Vector3(UnityEngine.Random.Range(0, 400), UnityEngine.Random.Range(0, 400), 0);
            goldCoin.SetActive(true);
        }

    }

    // Hit
    public void Hit()
    {
        currentScore += hitPower * levelMultiplier;
        totalScore += hitPower;
        xp++;

        // Text
        Instantiate(plusObject, transform.position, transform.rotation);
    }

    // Shop
    public void ShopHouse()
    {
        if(currentScore >= shop1Price)
        {
            currentScore -= shop1Price;
            amount1 += 1;
            amount1Profit += (0.3f * amount1Upgrade);
            shop1Price = (int)(shop1Price * 1.2f);
        }
    }
    public void ShopTavern()
    {
        if (currentScore >= shop2Price)
        {
            currentScore -= shop2Price;
            amount2 += 1;
            amount2Profit += (1f * amount2Upgrade);
            shop2Price = (int)(shop2Price * 1.2f);
        }
    }
    public void ShopStable()
    {
        if (currentScore >= shop3Price)
        {
            currentScore -= shop3Price;
            amount3 += 1;
            amount3Profit += (4f * amount3Upgrade);
            shop3Price = (int)(shop3Price * 1.2f);
        }
    }
    public void ShopBakery()
    {
        if (currentScore >= shop4Price)
        {
            currentScore -= shop4Price;
            amount4 += 1;
            amount4Profit += (20f * amount4Upgrade);
            shop4Price = (int)(shop4Price * 1.2f);
        }
    }
    public void ShopChurch()
    {
        if (currentScore >= shop5Price)
        {
            currentScore -= shop5Price;
            amount5 += 1;
            amount5Profit += (120f * amount5Upgrade);
            shop5Price = (int)(shop5Price * 1.2f);
        }
    }

    // Upgrades
    public void UpgradeClick()
    {
        if(currentScore >= clickUpgradePrice)
        {
            currentScore -= clickUpgradePrice;
            clickUpgradePrice *= 3;
            hitPower *= 2;
        }
    }

    public void UpgradeAllProfits()
    {
        if(currentScore >= allUpgradePrice)
        {
            currentScore -= allUpgradePrice;
            allUpgradePrice *= 3;
            amount1Profit *= 2;
            amount1Upgrade *= 2;
            amount2Profit *= 2;
            amount2Upgrade *= 2;
            amount3Profit *= 2;
            amount3Upgrade *= 2;
            amount4Profit *= 2;
            amount4Upgrade *= 2;
            amount5Profit *= 2;
            amount5Upgrade *= 2;
        }
    }

    public void UpgradeHouse()
    {
        if(currentScore >= houseUpgradePrice)
        {
            currentScore -= houseUpgradePrice;
            houseUpgradePrice *= 3;
            amount1Profit *= 2;
            amount1Upgrade *= 2;
        }
    }
    public void UpgradeTavern()
    {
        if (currentScore >= tavernUpgradePrice)
        {
            currentScore -= tavernUpgradePrice;
            tavernUpgradePrice *= 3;
            amount2Profit *= 2;
            amount2Upgrade *= 2;
        }
    }
    public void UpgradeStable()
    {
        if (currentScore >= stableUpgradePrice)
        {
            currentScore -= stableUpgradePrice;
            stableUpgradePrice *= 3;
            amount3Profit *= 2;
            amount3Upgrade *= 2;
        }
    }
    public void UpgradeBakery()
    {
        if (currentScore >= bakeryUpgradePrice)
        {
            currentScore -= bakeryUpgradePrice;
            bakeryUpgradePrice *= 3;
            amount4Profit *= 2;
            amount4Upgrade *= 2;
        }
    }
    public void UpgradeChurch()
    {
        if (currentScore >= churchUpgradePrice)
        {
            currentScore -= churchUpgradePrice;
            churchUpgradePrice *= 3;
            amount5Profit *= 2;
            amount5Upgrade *= 2;
        }
    }

    // Random Events
    public void GetReward()
    {
        currentScore = currentScore + (((amount1Profit + amount2Profit + amount3Profit + amount4Profit + amount5Profit)
        * levelMultiplier) * UnityEngine.Random.Range(60, 120));
        eventIsNow = false;
        StartCoroutine(WaitForEvent());
    }

    IEnumerator WaitForEvent()
    {
        yield return new WaitForSeconds(150f);

        int x = 0;
        x = UnityEngine.Random.Range(1,3);

        if (x == 2)
        {
            eventIsNow = true;
        }
        else
        {
            goldCoin.SetActive(true);
        }
    }
}

