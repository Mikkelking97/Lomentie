using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Hero_Leveling : MonoBehaviour
{
    public TMP_Text displaycurrentXP;

    
    //Your current level.
   public int level = 1;

    //Current XP Amount.
   public int currentXP = 0;

    //XP left until leveling up.
   public int eXPleft = 10;

    //How much more xp you need for each levelup.    
   public float eXPincreasemodifier = 1.5f;

   void Start()
   {
        displaycurrentXP.SetText(level.ToString());
   }

//Button to click to gain XP
public void ClickToGainXP(int e)
{
    currentXP += e;

    if(currentXP >= eXPleft)
    {
        LevelUp();
    }
}

    private void LevelUp()
    {
        currentXP -= eXPleft;
        level ++;
        float t = Mathf.Pow(eXPincreasemodifier, level);
        Debug.Log("Reads...");
        displaycurrentXP.SetText(level.ToString());
    }

}
