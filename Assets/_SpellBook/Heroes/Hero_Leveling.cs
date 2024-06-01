using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Hero_Leveling : MonoBehaviour
{
    public TMP_Text displaycurrentLVL;

    
    //Your current level.
   public int level = 1;

    //Current XP Amount.
   public int currentXP = 0;

    //XP left until leveling up.
   public int eXPThreshold = 10;

    //How much more xp you need for each levelup.    
   public float eXPincreasemodifier = 1.1f;

   void Start()
   {
        displaycurrentLVL.SetText(level.ToString());
   }

//Button to click to gain XP
public void ClickToGainXP(int e)
{
    currentXP += e;

    if(currentXP >= eXPThreshold)
    {
        LevelUp();
    }
}

    private void LevelUp()
    {   // resets the current xp for next lvl up.
        currentXP -= eXPThreshold;
        level ++;
        
        /* Test one.
        float t = Mathf.Pow(eXPincreasemodifier, level);
        eXPThreshold = (int)Mathf.Floor(eXPincreasemodifier * t);
        */
       
       eXPThreshold = eXPThreshold + 10;

        displaycurrentLVL.SetText(level.ToString());
    }

}
