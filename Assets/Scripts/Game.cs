using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;

// Unsigned 32bit int limit keeps getting reached - NEEDS FIXING ASAP!
// Fix in the works fingers crossed :3

public class Game : MonoBehaviour
{
    // Clicker
    [Header("Clicker")]
    public Text scoreText;
    [Header("Current Score")]
    public double currentScore;
    [Header("Current Ones - Nonillions")]
    public double currentOnesTensHundreds;
    public double currentThousands;
    public double currentMillions;
    public double currentBillions;
    public double currentTrillions;
    public double currentQuadrillons;
    public double currentQuintrillons;
    public double currentSextillons;
    public double currentSeptillons;
    public double currentOctillions;
    public double currentNonillions;
    [Header("Current Decillions")]
    public double currentDecillions;
    public double currentUndecillions;
    public double currentDuodecillions;
    public double currentTredecillions;
    public double currentQuaddecillions;
    public double currentQuindecillions;
    public double currentSexdecillions;
    public double currentSeptdecillions;
    public double currentOctodecillions;
    public double currentNovemdecillions;
    [Header("Current Vigintillions")]
    public double currentVigintillions;
    public double currentDuovigintillions;
    public double currentTresvigintillions;
    public double currentQuattorvigintillions;
    public double currentQuinvigintillions;
    public double currentSexvigintillions;
    public double currentSeptenvigintillions;
    public double currentOctovigintillions;
    public double currentNovemvigintillions;

    [Header("Total Score")]
    public double totalScore;
    [Header("Total Ones - Nonillions")]
    public double totalOnesTensHundreds;
    public double totalThousands;
    public double totalMillions;
    public double totalBillions;
    public double totalTrillions;
    public double totalQuadrillons;
    public double totalQuintrillons;
    public double totalSextillons;
    public double totalSeptillons;
    public double totalOctillions;
    public double totalNonillions;
    [Header("Total Decillions")]
    public double totalDecillions;
    public double totalUndecillions;
    public double totalDuodecillions;
    public double totalTredecillions;
    public double totalQuaddecillions;
    public double totalQuindecillions;
    public double totalSexdecillions;
    public double totalSeptdecillions;
    public double totalOctodecillions;
    public double totalNovemdecillions;
    [Header("Total Vigintillions")]
    public double totalVigintillions;
    public double totalDuovigintillions;
    public double totalTresvigintillions;
    public double totalQuattorvigintillions;
    public double totalQuinvigintillions;
    public double totalSexvigintillions;
    public double totalSeptenvigintillions;
    public double totalOctovigintillions;
    public double totalNovemvigintillions;

    [Header("Hitpower")] // KEEP THESE AS STATICS
    public static double hitPower;
    [Header("Hitpower Ones - Nonillions")]
    public static double hitpowerOnesTensHundreds;
    public static double hitpowerThousands;
    public static double hitpowerMillions;
    public static double hitpowerBillions;
    public static double hitpowerTrillions;
    public static double hitpowerQuadrillons;
    public static double hitpowerQuintrillons;
    public static double hitpowerSextillons;
    public static double hitpowerSeptillons;
    public static double hitpowerOctillions;
    public static double hitpowerNonillions;
    [Header("Hitpower Decillions")]
    public static double hitpowerDecillions;
    public static double hitpowerUndecillions;
    public static double hitpowerDuodecillions;
    public static double hitpowerTredecillions;
    public static double hitpowerQuaddecillions;
    public static double hitpowerQuindecillions;
    public static double hitpowerSexdecillions;
    public static double hitpowerSeptdecillions;
    public static double hitpowerOctodecillions;
    public static double hitpowerNovemdecillions;
    [Header("Hitpower Vigintillions")]
    public static double hitpowerVigintillions;
    public static double hitpowerDuovigintillions;
    public static double hitpowerTresvigintillions;
    public static double hitpowerQuattorvigintillions;
    public static double hitpowerQuinvigintillions;
    public static double hitpowerSexvigintillions;
    public static double hitpowerSeptenvigintillions;
    public static double hitpowerOctovigintillions;
    public static double hitpowerNovemvigintillions;
    [Header("Score Increase")]
    public double scoreIncreasedPerSecond;
    [Header("Increase Ones - Nonillions")]
    public double increaseOnesTensHundreds;
    public double increaseThousands;
    public double increaseMillions;
    public double increaseBillions;
    public double increaseTrillions;
    public double increaseQuadrillons;
    public double increaseQuintrillons;
    public double increaseSextillons;
    public double increaseSeptillons;
    public double increaseOctillions;
    public double increaseNonillions;
    [Header("Increase Decillions")]
    public double increaseDecillions;
    public double increaseUndecillions;
    public double increaseDuodecillions;
    public double increaseTredecillions;
    public double increaseQuaddecillions;
    public double increaseQuindecillions;
    public double increaseSexdecillions;
    public double increaseSeptdecillions;
    public double increaseOctodecillions;
    public double increaseNovemdecillions;
    [Header("Increase Vigintillions")]
    public double increaseVigintillions;
    public double increaseDuovigintillions;
    public double increaseTresvigintillions;
    public double increaseQuattorvigintillions;
    public double increaseQuinvigintillions;
    public double increaseSexvigintillions;
    public double increaseSeptenvigintillions;
    public double increaseOctovigintillions;
    public double increaseNovemvigintillions;

    // Shop
    [Header("Shop")]

    [Header("House")]
    public Text shop1Text;
    
    [Header("House Cost")]
    public double shop1Price;
    
    [Header("House Ones - Nonillions")]
    public double shop1CostOnesTensHundreds;
    public double shop1CostThousands;
    public double shop1CostMillions;
    public double shop1CostBillions;
    public double shop1CostTrillions;
    public double shop1CostQuadrillons;
    public double shop1CostQuintrillons;
    public double shop1CostSextillons;
    public double shop1CostSeptillons;
    public double shop1CostOctillions;
    public double shop1CostNonillions;
    
    [Header("House Decillions")]
    public double shop1CostDecillions;
    public double shop1CostUndecillions;
    public double shop1CostDuodecillions;
    public double shop1CostTredecillions;
    public double shop1CostQuaddecillions;
    public double shop1CostQuindecillions;
    public double shop1CostSexdecillions;
    public double shop1CostSeptdecillions;
    public double shop1CostOctodecillions;
    public double shop1CostNovemdecillions;
    
    [Header("House Vigintillions")]
    public double shop1CostVigintillions;
    public double shop1CostDuovigintillions;
    public double shop1CostTresvigintillions;
    public double shop1CostQuattorvigintillions;
    public double shop1CostQuinvigintillions;
    public double shop1CostSexvigintillions;
    public double shop1CostSeptenvigintillions;
    public double shop1CostOctovigintillions;
    public double shop1CostNovemvigintillions;


    [Header("Tavern")]
    public Text shop2Text;

    [Header("Tavern Cost")]
    public double shop2Price;

    [Header("Tavern Ones - Nonillions")]
    public double shop2CostOnesTensHundreds;
    public double shop2CostThousands;
    public double shop2CostMillions;
    public double shop2CostBillions;
    public double shop2CostTrillions;
    public double shop2CostQuadrillons;
    public double shop2CostQuintrillons;
    public double shop2CostSextillons;
    public double shop2CostSeptillons;
    public double shop2CostOctillions;
    public double shop2CostNonillions;

    [Header("Tavern Decillions")]
    public double shop2CostDecillions;
    public double shop2CostUndecillions;
    public double shop2CostDuodecillions;
    public double shop2CostTredecillions;
    public double shop2CostQuaddecillions;
    public double shop2CostQuindecillions;
    public double shop2CostSexdecillions;
    public double shop2CostSeptdecillions;
    public double shop2CostOctodecillions;
    public double shop2CostNovemdecillions;

    [Header("Tavern Vigintillions")]
    public double shop2CostVigintillions;
    public double shop2CostDuovigintillions;
    public double shop2CostTresvigintillions;
    public double shop2CostQuattorvigintillions;
    public double shop2CostQuinvigintillions;
    public double shop2CostSexvigintillions;
    public double shop2CostSeptenvigintillions;
    public double shop2CostOctovigintillions;
    public double shop2CostNovemvigintillions;


    [Header("Stable")]
    public Text shop3Text;

    [Header("Stable Cost")]
    public double shop3Price;

    [Header("Stable Ones - Nonillions")]
    public double shop3CostOnesTensHundreds;
    public double shop3CostThousands;
    public double shop3CostMillions;
    public double shop3CostBillions;
    public double shop3CostTrillions;
    public double shop3CostQuadrillons;
    public double shop3CostQuintrillons;
    public double shop3CostSextillons;
    public double shop3CostSeptillons;
    public double shop3CostOctillions;
    public double shop3CostNonillions;

    [Header("Stable Decillions")]
    public double shop3CostDecillions;
    public double shop3CostUndecillions;
    public double shop3CostDuodecillions;
    public double shop3CostTredecillions;
    public double shop3CostQuaddecillions;
    public double shop3CostQuindecillions;
    public double shop3CostSexdecillions;
    public double shop3CostSeptdecillions;
    public double shop3CostOctodecillions;
    public double shop3CostNovemdecillions;

    [Header("Stable Vigintillions")]
    public double shop3CostVigintillions;
    public double shop3CostDuovigintillions;
    public double shop3CostTresvigintillions;
    public double shop3CostQuattorvigintillions;
    public double shop3CostQuinvigintillions;
    public double shop3CostSexvigintillions;
    public double shop3CostSeptenvigintillions;
    public double shop3CostOctovigintillions;
    public double shop3CostNovemvigintillions;


    [Header("Bakery")]
    public Text shop4Text;

    [Header("Bakery Cost")]
    public double shop4Price;

    [Header("Bakery Ones - Nonillions")]
    public double shop4CostOnesTensHundreds;
    public double shop4CostThousands;
    public double shop4CostMillions;
    public double shop4CostBillions;
    public double shop4CostTrillions;
    public double shop4CostQuadrillons;
    public double shop4CostQuintrillons;
    public double shop4CostSextillons;
    public double shop4CostSeptillons;
    public double shop4CostOctillions;
    public double shop4CostNonillions;

    [Header("Bakery Decillions")]
    public double shop4CostDecillions;
    public double shop4CostUndecillions;
    public double shop4CostDuodecillions;
    public double shop4CostTredecillions;
    public double shop4CostQuaddecillions;
    public double shop4CostQuindecillions;
    public double shop4CostSexdecillions;
    public double shop4CostSeptdecillions;
    public double shop4CostOctodecillions;
    public double shop4CostNovemdecillions;

    [Header("Bakery Vigintillions")]
    public double shop4CostVigintillions;
    public double shop4CostDuovigintillions;
    public double shop4CostTresvigintillions;
    public double shop4CostQuattorvigintillions;
    public double shop4CostQuinvigintillions;
    public double shop4CostSexvigintillions;
    public double shop4CostSeptenvigintillions;
    public double shop4CostOctovigintillions;
    public double shop4CostNovemvigintillions;


    [Header("Church")]
    public Text shop5Text;

    [Header("Church Cost")]
    public double shop5Price;

    [Header("Church Ones - Nonillions")]
    public double shop5CostOnesTensHundreds;
    public double shop5CostThousands;
    public double shop5CostMillions;
    public double shop5CostBillions;
    public double shop5CostTrillions;
    public double shop5CostQuadrillons;
    public double shop5CostQuintrillons;
    public double shop5CostSextillons;
    public double shop5CostSeptillons;
    public double shop5CostOctillions;
    public double shop5CostNonillions;

    [Header("Church Decillions")]
    public double shop5CostDecillions;
    public double shop5CostUndecillions;
    public double shop5CostDuodecillions;
    public double shop5CostTredecillions;
    public double shop5CostQuaddecillions;
    public double shop5CostQuindecillions;
    public double shop5CostSexdecillions;
    public double shop5CostSeptdecillions;
    public double shop5CostOctodecillions;
    public double shop5CostNovemdecillions;

    [Header("Church Vigintillions")]
    public double shop5CostVigintillions;
    public double shop5CostDuovigintillions;
    public double shop5CostTresvigintillions;
    public double shop5CostQuattorvigintillions;
    public double shop5CostQuinvigintillions;
    public double shop5CostSexvigintillions;
    public double shop5CostSeptenvigintillions;
    public double shop5CostOctovigintillions;
    public double shop5CostNovemvigintillions;


    // Buildings
    [Header("Buildings")]

    [Header("House")]
    public Int64 amount1;
    public Text amount1Text;

    public double amount1Upgrade;
    public double amount1Profit;
    [Header("Tavern")]
    public Int64 amount2;
    public Text amount2Text;

    public double amount2Upgrade;
    public double amount2Profit;
    [Header("Stable")]
    public Int64 amount3;
    public Text amount3Text;

    public double amount3Upgrade;
    public double amount3Profit;
    [Header("Bakery")]
    public Int64 amount4;
    public Text amount4Text;

    public double amount4Upgrade;
    public double amount4Profit;
    [Header("Church")]
    public Int64 amount5;
    public Text amount5Text;

    public double amount5Upgrade;
    public double amount5Profit;

    // Upgrades
    [Header("Upgrades")]

    [Header("Non-building Upgrades")]
    public double allUpgradePrice;
    public Text allUpgradeText;
    public double clickUpgradePrice;
    public Text clickUpgradeText;
    [Header("Buildings 1-5 Upgrades")]
    public double houseUpgradePrice;
    public Text houseUpgradeText;
    public double tavernUpgradePrice;
    public Text tavernUpgradeText;
    public double stableUpgradePrice;
    public Text stableUpgradeText;
    public double bakeryUpgradePrice;
    public Text bakeryUpgradeText;
    public double churchUpgradePrice;
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
    public string levelString;

    public double xp;
    public string xpString;

    public double xpToNextLevel;
    public string xpToNextLevelString;

    public double levelMultiplier;
    public string levelMultiplierString;

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
        increaseOnesTensHundreds = (amount1Profit + amount2Profit + amount3Profit + amount4Profit + amount5Profit) * levelMultiplier * Time.deltaTime;
        currentOnesTensHundreds = currentOnesTensHundreds + increaseOnesTensHundreds;
        totalOnesTensHundreds = totalOnesTensHundreds + increaseOnesTensHundreds;

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


        // Test
        totalOnesTensHundreds = totalOnesTensHundreds + scoreIncreasedPerSecond;
        
        if (totalOnesTensHundreds >= 1000)
        {
            totalThousands++;
            totalOnesTensHundreds = 0;
        }
        

        if (totalThousands >= 1000)
        {
            totalMillions++;
            totalThousands = 0;
       
        }
        if (totalMillions >= 1000)
        {
            totalBillions++;
            totalMillions = 0;
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

