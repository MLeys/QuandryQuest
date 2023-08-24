using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public string name;
    public int exp = 0;

    public Character()
    {
        name = "not assigned";
    }

    public Character(string name) 
    {
        this.name = name;
    }
    
    public void PrintStatsInfo()
    {
        Debug.LogFormat("Hero: {0} - {1} EXP", this.name, this.exp);
    }

}
