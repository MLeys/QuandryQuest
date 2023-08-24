using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    int CurrentAge = 30;
    public int AddedAge = 1;
    public int MaxPlayerHealth = 100;
    public string CharacterClass = "Ranger";

    public bool hasDungeonKey = true;
    public int CurrentGold = 32;
    public bool weaponEquipped = true;
    public string weaponType = "Longsword";
    public bool PureOfHeart = true;
    public bool HasSecretIncantation  = false;
    public string RareItem = "Relic Stone";

    void Start()
    {
        OpenTreasureChamber();
        if(weaponEquipped)
        {
            if(weaponType == "Longsword")
            {
                Debug.Log("For the Queen!");
            }
        }
        else 
        {
            Debug.Log("Fists aren't going to work against armor...");
        }
        Thievery();       

        int CharacterHealth = 100;
        int CharacterLevel = 32;
        int NextSkillLevel = GenerateCharacter("Mike", CharacterLevel);

        // GenerateCharacter("Spike", CharacterLevel);

        // Debug.Log(CharacterClass + " - HP: " + CharacterHealth);
        Debug.Log(NextSkillLevel);
        Debug.Log(GenerateCharacter("Faye", CharacterLevel));
    }

    public void Thievery()
    {
        if (CurrentGold > 50) 
        {
            Debug.Log("You're rolling in it!");
        }
        else if (CurrentGold < 15)
        {
            Debug.Log("Not much there to steal...");
        }
        else
        {
            Debug.Log("Looks like your purse is in the sweet spot.");
        }
    }

    public void OpenTreasureChamber()
    {
        if(PureOfHeart && RareItem == "Relic Stone")
        {
            if(!HasSecretIncantation)
            {
                Debug.Log("You have the spirit, but not the knowledge.");
            }
            else
            {
                Debug.Log("The treasure is yours, worthy hero!");
            }
        }
        else
        {
            Debug.Log("Come back when you have what it takes.");
        }
    }

    /// <summary>
    /// Runs as soon as object called on first frame
    /// </summary>


    public int GenerateCharacter(string name, int level)
    {
        // Debug.LogFormat("Character: {0} - Level: {1}", name, level);

        return level += 5;
    }

    void CreateCharacter()
    {
        string CharacterName = "Aragon";
        Debug.Log(CharacterName + " - " + CharacterClass);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
