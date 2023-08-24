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

 public string CharacterAction = "Attack";
void Start()
{
    Character hero = new Character();
 Debug.LogFormat("Hero: {0} - {1} EXP", hero.name, hero.exp);
}

public void FindPartyMember()
{
    List<string> QuestPartyMembers = new List<string>()
    {
        "Grim the Barbarian",
        "Merlin the Wise",
        "Sterling the Knight"
    };
    int listLength = QuestPartyMembers.Count;
    QuestPartyMembers.Add("Craven the Necromancer");
    QuestPartyMembers.Insert(1, "Tanis the Thief");
    QuestPartyMembers.RemoveAt(0);
    //QuestPartyMembers.Remove("Grim the Barbarian");
    
    Debug.LogFormat("Party Members: {0}", listLength);
    for(int i = 0; i < listLength; i++)
    {
        Debug.LogFormat("Index: {0} - {1}", i, QuestPartyMembers[i]);
        if(QuestPartyMembers[i] == "Merlin the Wise")
        {
            Debug.Log("Glad you're here Merlin!");
        }
    }
}

public void PrintCharacterAction()
{
    switch(CharacterAction)
    {
        case "Heal":
            Debug.Log("Potion sent.");
            break;
        case "Attack":
            Debug.Log("To arms!");
            break;
        default:
            Debug.Log("Shields up.");
            break;
    }
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
