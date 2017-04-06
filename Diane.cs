using UnityEngine;
using System.Collections;

public class Diane : MonoBehaviour {
    //keeps track of stats throughout battles
    public static readonly int THP = 100, TMP = 100, ATT = 5;
    public static readonly double CRT = 0.2;
    public static int cHP = 100, cMP = 100;
	void Start () {
	
	}
	
	void Update () {
	
	}

    public static int Attack(bool crit)
    {
        if (crit)
        {
            return (int)(ATT + (ATT * CRT));
            //prompt crit pop up
            //extra damage sound
        }
        else
        {
            return ATT;
            //adjust health bar animation
        }
    }

    public static void Damage(int attVal, bool blocked, bool pBlocked)
    {
        if (blocked)
        {

        }
        else if (pBlocked)
        {
            cHP -= ((int)attVal/2);
            //adjust health bar animation
        }
        else
        {
            cHP -= (attVal);
            //adjust health bar animation
        }
    }
}
