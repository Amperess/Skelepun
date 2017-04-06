using UnityEngine;
using System.Collections;

public class Monster : MonoBehaviour {
    //more stats, default but will be set according to the monster
    public static int THP, TMP, ATT, cHP, cMP;
    public static double crt, def;
    void Start () {

    }
	
	void Update () {
	
	}
    public static void Initialize(int monNum)
    {
        switch(monNum)
        {
            case 1:
                //first monster type
                THP = 20;
                TMP = 20;
                ATT = 5;
                cHP = THP;
                cMP = TMP;
                crt = 0.1;
                def = 0.1;
                break;
            case 2:
                //minor jelly
                THP = 10;
                TMP = 20;
                ATT = 1;
                cHP = THP;
                cMP = TMP;
                crt = 0.1;
                def = 0.05;
                break;
            case 3:
                //major jelly
                THP = 75;
                TMP = 50;
                ATT = 10;
                cHP = THP;
                cMP = TMP;
                crt = 0.35;
                def = 0.35;
                break;
        }
    }

    public static int Attack()
    {
        bool critDam = false;
        int rand = (int)(Random.value * 99) + 1;
        if (rand < crt * 100)
            critDam = true;
        if (critDam)
        {
            return (int)(ATT + (ATT * crt));
            //prompt crit pop up
            //extra damage sound
        }
        else
        {
            return ATT;
        }
    }

    public static void Damage(int attVal)
    {
        bool pBlocked = false;
        int rand = (int)(Random.value*99)+1;
        if (rand < def * 100)
            pBlocked = true;
        if (pBlocked)
        {
            cHP -= ((int)attVal / 2);
            //adjust health bar animation
            //trigger blocked pop up
        }
        else
        {
            cHP -= (attVal);
            //adjust health bar animation
        }
    }
}
