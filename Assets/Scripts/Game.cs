using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Numerics;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;

// Unsigned 32bit int limit keeps getting reached - NEEDS FIXING ASAP!
// Fix in the works fingers crossed :3
// THIS IS ACTUALLY SO HARD BRO IM CLOSE TO GIVING UP!!!!!!
// Lists save me...
// Reset prefs at line 225

public class Game : MonoBehaviour
{
    // Clicker
    [Header("Clicker")]
    public Text scoreText;
    public List<string> scoreList = new List<string>();
    
    [Header("Current Score")]
    public double currentScore;
    public List<double> currentScoreList = new List<double>();

    [Header("Total Score")]
    public double totalScore;
    public List<double> totalScoreList = new List<double>();

    [Header("Hitpower")] // KEEP THESE AS STATICS
    public static double hitPower;
    public static List<double> hitPowerList = new List<double>();

    [Header("Score Increase")]
    public double scoreIncreasedPerSecond;
    public List<double> scoreIncreaseList = new List<double>();

    // test
    public Text testText;
    public double testVar;

    // Shop
    [Header("Shop")]

    [Header("House")]
    public Text shop1Text;
    public double shop1Price;
    public List<double> shop1List = new List<double>();

    [Header("Tavern")]
    public Text shop2Text;
    public double shop2Price;
    public List<double> shop2List = new List<double>();

    [Header("Stable")]
    public Text shop3Text;
    public double shop3Price;
    public List<double> shop3List = new List<double>();

    [Header("Bakery")]
    public Text shop4Text;
    public double shop4Price;
    public List<double> shop4List = new List<double>();

    [Header("Church")]
    public Text shop5Text;
    public double shop5Price;
    public List<double> shop5List = new List<double>();

    // Buildings
    [Header("Buildings")]

    [Header("House")]
    public Int64 amount1;
    public Text amount1Text;
    public double amount1Upgrade;
    public List<double> shop1UpgradeList = new List<double>();
    public double amount1Profit;
    public List<double> shop1ProfitList = new List<double>();

    [Header("Tavern")]
    public Int64 amount2;
    public Text amount2Text;
    public double amount2Upgrade;
    public List<double> shop2UpgradeList = new List<double>();
    public double amount2Profit;
    public List<double> shop2ProfitList = new List<double>();

    [Header("Stable")]
    public Int64 amount3;
    public Text amount3Text;
    public double amount3Upgrade;
    public List<double> shop3UpgradeList = new List<double>();
    public double amount3Profit;
    public List<double> shop3ProfitList = new List<double>();

    [Header("Bakery")]
    public Int64 amount4;
    public Text amount4Text;
    public double amount4Upgrade;
    public List<double> shop4UpgradeList = new List<double>();
    public double amount4Profit;
    public List<double> shop4ProfitList = new List<double>();

    [Header("Church")]
    public Int64 amount5;
    public Text amount5Text;
    public double amount5Upgrade;
    public List<double> shop5UpgradeList = new List<double>();
    public double amount5Profit;
    public List<double> shop5ProfitList = new List<double>();

    // Upgrades
    [Header("Upgrades")]

    [Header("Non-building Upgrades")]

    [Header("Overall Upgrades")]
    public double allUpgradePrice;
    public List<double> allUpgradePriceList = new List<double>();
    public Text allUpgradeText;
    [Header("Click Upgrades")]
    public double clickUpgradePrice;
    public List<double> clickUpgradePriceList = new List<double>();
    public Text clickUpgradeText;

    [Header("Building Upgrades")]
    
    [Header("House Upgrades")]
    public double houseUpgradePrice;
    public List<double> houseUpgradePriceList = new List<double>();
    public Text houseUpgradeText;
    [Header("Tavern Upgrades")]
    public double tavernUpgradePrice;
    public List<double> tavernUpgradePriceList = new List<double>();
    public Text tavernUpgradeText;
    [Header("Stable Upgrades")]
    public double stableUpgradePrice;
    public List<double> stableUpgradePriceList = new List<double>();
    public Text stableUpgradeText;
    [Header("Bakery Upgrades")]
    public double bakeryUpgradePrice;
    public List<double> bakeryUpgradePriceList = new List<double>();
    public Text bakeryUpgradeText;
    [Header("Church Upgrades")]
    public double churchUpgradePrice;
    public List<double> churchUpgradePriceList = new List<double>();
    public Text churchUpgradeText;

    // Achievements
    [Header("Achievements")]

    [Header("Score Achievements")]
    public bool achievementScore;
    [Header("House Achievements")]
    public bool achievementHouse;
    [Header("Tavern Achievements")]
    public bool achievementTavern;
    [Header("Stable Achievements")]
    public bool achievementStable;
    [Header("Bakery Achievements")]
    public bool achievementBakery;
    [Header("Church Achievements")]
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
    public double level;
    public List<double> levelList = new List<double>();

    public double xp;
    public List<double> xpList = new List<double>();

    public double xpToNextLevel;
    public List<double> xpToNextLevelList = new List<double>();

    public static double levelMultiplier;

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

    // Audio
    AudioManager audioManager;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

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
        PlayerPrefs.DeleteAll();

        // Load

        // Clicker

        // Current Score
        currentScore = PlayerPrefs.GetFloat("currentScore", 0);

        // Total Score
        totalScore = PlayerPrefs.GetFloat("totalScore", 0);
        
        // Hitpower
        hitPower = PlayerPrefs.GetFloat("hitPower", 1);
        
        // Shop
        shop1Price = PlayerPrefs.GetInt("shop1Price", 25);
        shop2Price = PlayerPrefs.GetInt("shop2Price", 100);
        shop3Price = PlayerPrefs.GetInt("shop3Price", 500);
        shop4Price = PlayerPrefs.GetInt("shop4Price", 3000);
        shop5Price = PlayerPrefs.GetInt("shop5Price", 21000);

        // House
        amount1 = PlayerPrefs.GetInt("amount1", 0);
        amount1Profit = PlayerPrefs.GetFloat("amount1Profit", 0);
        amount1Upgrade = PlayerPrefs.GetFloat("amount1Upgrade", 1);

        // Tavern
        amount2 = PlayerPrefs.GetInt("amount2", 0);
        amount2Profit = PlayerPrefs.GetFloat("amount2Profit", 0);
        amount2Upgrade = PlayerPrefs.GetFloat("amount2Upgrade", 1);

        // Stable
        amount3 = PlayerPrefs.GetInt("amount3", 0);
        amount3Profit = PlayerPrefs.GetFloat("amount3Profit", 0);
        amount3Upgrade = PlayerPrefs.GetFloat("amount3Upgrade", 1);

        // Bakery
        amount4 = PlayerPrefs.GetInt("amount4", 0);
        amount4Profit = PlayerPrefs.GetFloat("amount4Profit", 0);
        amount4Upgrade = PlayerPrefs.GetFloat("amount4Upgrade", 1);

        // Church
        amount5 = PlayerPrefs.GetInt("amount5", 0);
        amount5Profit = PlayerPrefs.GetFloat("amount5Profit", 0);
        amount5Upgrade = PlayerPrefs.GetFloat("amount5Upgrade", 1);

        // Upgrades
        clickUpgradePrice = PlayerPrefs.GetFloat("clickUpgradePrice", 100);
        allUpgradePrice = PlayerPrefs.GetFloat("allUpgradePrice", 2500);
        houseUpgradePrice = PlayerPrefs.GetFloat("houseUpgradePrice", 250);
        tavernUpgradePrice = PlayerPrefs.GetFloat("tavernUpgradePrice", 1000);
        stableUpgradePrice = PlayerPrefs.GetFloat("stableUpgradePrice", 5000);
        bakeryUpgradePrice = PlayerPrefs.GetFloat("bakeryUpgradePrice", 30000);
        churchUpgradePrice = PlayerPrefs.GetFloat("churchUpgradePrice", 210000);

        // Achievements
        achievementScore = PlayerPrefs.Equals("achievementScore", false);
        achievementHouse = PlayerPrefs.Equals("achievementHouse", false);
        achievementTavern = PlayerPrefs.Equals("achievementTavern", false);
        achievementStable = PlayerPrefs.Equals("achievementStable", false);
        achievementBakery = PlayerPrefs.Equals("achievementBakery", false);
        achievementChurch = PlayerPrefs.Equals("achievementChurch", false);
        
        // Level
        level = PlayerPrefs.GetFloat("level", 1);
        xp = PlayerPrefs.GetFloat("xp", 0);
        xpToNextLevel = PlayerPrefs.GetFloat("xpToNextLevel", 50);
    }

 
    void Update()
    {
       
        // Clicker
        scoreText.text = "£" + (int)currentScore;
        scoreIncreasedPerSecond = (amount1Profit + amount2Profit + amount3Profit + amount4Profit + amount5Profit) * levelMultiplier * Time.deltaTime;
        currentScore = currentScore + scoreIncreasedPerSecond;
        totalScore = totalScore + scoreIncreasedPerSecond;

        // Test
        currentScoreList[0] = currentScoreList[0] + scoreIncreasedPerSecond;
        scoreIncreaseList[0] = (amount1Profit + amount2Profit + amount3Profit + amount4Profit + amount5Profit) * levelMultiplier * Time.deltaTime;
        totalScoreList[0] = totalScoreList[0] + scoreIncreaseList[0];

        // Shop
        shop1Text.text = "House: £" + shop1Price;
        shop2Text.text = "Tavern: £" + shop2Price;
        shop3Text.text = "Stable: £" + shop3Price;
        shop4Text.text = "Bakery: £" + shop4Price;
        shop5Text.text = "Church: £" + shop5Price;

        // Amount
        string ap1 = (amount1Profit * levelMultiplier).ToString("F2");
        amount1Text.text = amount1 + " Houses: £" + ap1 + "/s";
        string ap2 = (amount2Profit * levelMultiplier).ToString("F2");
        amount2Text.text = amount2 + " Taverns: £" + ap2 + "/s";
        string ap3 = (amount3Profit * levelMultiplier).ToString("F2");
        amount3Text.text = amount3 + " Stables: £" + ap3 + "/s";
        string ap4 = (amount4Profit * levelMultiplier).ToString("F2");
        amount4Text.text = amount4 + " Bakeries: £" + ap4 + "/s";
        string ap5 = (amount5Profit * levelMultiplier).ToString("F2");
        amount5Text.text = amount5 + " Churches: £" + ap5 + "/s";

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

        // Clicker
        PlayerPrefs.SetFloat("currentScore", (float)currentScore);
        PlayerPrefs.SetFloat("totalScore", (int)totalScore);
        PlayerPrefs.SetFloat("hitPower", (int)hitPower);

        // Shop
        PlayerPrefs.SetInt("shop1Price", (int)shop1Price);
        PlayerPrefs.SetInt("shop2Price", (int)shop2Price);
        PlayerPrefs.SetInt("shop3Price", (int)shop3Price);
        PlayerPrefs.SetInt("shop4Price", (int)shop4Price);
        PlayerPrefs.SetInt("shop5Price", (int)shop5Price);

        // House
        PlayerPrefs.SetInt("amount1", (int)amount1);
        PlayerPrefs.SetFloat("amount1Profit", (float)amount1Profit);
        PlayerPrefs.SetFloat("amount1Upgrade", (int)amount1Upgrade);

        // Tavern
        PlayerPrefs.SetInt("amount2", (int)amount2);
        PlayerPrefs.SetFloat("amount2Profit", (float)amount2Profit);
        PlayerPrefs.SetFloat("amount2Upgrade", (int)amount2Upgrade);

        // Stable
        PlayerPrefs.SetInt("amount3", (int)amount3);
        PlayerPrefs.SetFloat("amount3Profit", (float)amount3Profit);
        PlayerPrefs.SetFloat("amount3Upgrade", (int)amount3Upgrade);

        // Bakery
        PlayerPrefs.SetInt("amount4", (int)amount4);
        PlayerPrefs.SetFloat("amount4Profit", (float)amount4Profit);
        PlayerPrefs.SetFloat("amount4Upgrade", (int)amount4Upgrade);

        // Church
        PlayerPrefs.SetInt("amount5", (int)amount5);
        PlayerPrefs.SetFloat("amount5Profit", (float)amount5Profit);
        PlayerPrefs.SetFloat("amount5Upgrade", (int)amount5Upgrade);

        // Upgrades
        PlayerPrefs.SetFloat("clickUpgradePrice", (int)clickUpgradePrice);
        PlayerPrefs.SetFloat("allUpgradePrice", (int)allUpgradePrice);
        PlayerPrefs.SetFloat("houseUpgradePrice", (int)houseUpgradePrice);
        PlayerPrefs.SetFloat("tavernUpgradePrice", (int)tavernUpgradePrice);
        PlayerPrefs.SetFloat("stableUpgradePrice", (int)stableUpgradePrice);
        PlayerPrefs.SetFloat("bakeryUpgradePrice", (int)bakeryUpgradePrice);
        PlayerPrefs.SetFloat("churchUpgradePrice", (int)churchUpgradePrice);

        // Achievements
        PlayerPrefs.Equals("achievementScore", (bool)achievementScore);
        PlayerPrefs.Equals("achievementHouse", (bool)achievementHouse);
        PlayerPrefs.Equals("achievementTavern", (bool)achievementTavern);
        PlayerPrefs.Equals("achievementStable", (bool)achievementStable);
        PlayerPrefs.Equals("achievementBakery", (bool)achievementBakery);
        PlayerPrefs.Equals("achievementChurch", (bool)achievementChurch);

        // Level
        PlayerPrefs.SetFloat("level", (int)level);
        PlayerPrefs.SetFloat("xp", (int)xp);
        PlayerPrefs.SetFloat("xpToNextLevel", (int)xpToNextLevel);

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
            goldCoin.transform.position = new UnityEngine.Vector3(UnityEngine.Random.Range(0, 400), UnityEngine.Random.Range(0, 400), 0);
            StartCoroutine(WaitForEvent());
        }
        
        if(eventIsNow == true && goldCoin.active == false)
        {
            goldCoin.transform.position = new UnityEngine.Vector3(UnityEngine.Random.Range(0, 400), UnityEngine.Random.Range(0, 400), 0);
            goldCoin.SetActive(true);
        }
    
        // TEST

        if (totalScoreList[0] >= 1000)
        {
            totalScoreList[1]++;
            totalScoreList[0] = totalScoreList[0] - 1000;
        }
        

        if (totalScoreList[1] >= 1000)
        {
            totalScoreList[2]++;
            totalScoreList[1] = totalScoreList[1] - 1000;

        }
        if (totalScoreList[2] >= 1000)
        {
            totalScoreList[3]++;
            totalScoreList[2] = totalScoreList[2] - 1000;
        }

        if (currentScoreList[3] >= 1000)
        {
            currentScoreList[4]++;
            totalScoreList[3] = totalScoreList[3] - 1000;
        }
    }

    // Hit
    public void Hit()
    {
        currentScore += hitPower * levelMultiplier;
        totalScore += hitPower * levelMultiplier;
        totalScoreList[0] += hitPower * levelMultiplier;
        xp++;

        // Audio
        audioManager.PlaySFX(audioManager.click);

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
            audioManager.PlaySFX(audioManager.saw);
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
            audioManager.PlaySFX(audioManager.saw);
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
            audioManager.PlaySFX(audioManager.saw);
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
            audioManager.PlaySFX(audioManager.saw);
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
            audioManager.PlaySFX(audioManager.saw);
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
            allUpgradePrice *= 5;
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
        * levelMultiplier) * UnityEngine.Random.Range(30, 60));
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

