using UnityEngine;
using System.Collections;

public class Battle : MonoBehaviour {

	void Start () {
        //set the stats of current monster
        Monster.Initialize(Initial.monsterNum);
        Debug.Log("Hey, just initialized the monster for you :D");
        GameObject monSpr;
        switch (Initial.monsterNum)
        {
            case 1:
                monSpr = GameObject.FindWithTag("monSoul");
                break;
            case 2:
                monSpr = GameObject.FindWithTag("monSoul");
                Debug.Log("Case 2 Monster");
                break;
            default:
                monSpr = GameObject.FindWithTag("monSoul");
                Debug.Log("Uh oh Default case Monster");
                break;
        }
        monSpr.GetComponent<Renderer>().enabled = true;
	}
	
	void Update () {
	
	}
}
