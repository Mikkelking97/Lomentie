using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Attributes : Hero_Leveling
{
    
    public int upgradepoints;
    public TMP_Text attributeSTR;
    

    public int strength;
    public int vitality;

    void Start()
    {

    }

    public void Spendpoints()
    {
        attributeSTR.SetText(level.ToString());
    }

}
