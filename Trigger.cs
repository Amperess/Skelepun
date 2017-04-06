using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Trigger : MonoBehaviour
{ 
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            transform.parent.gameObject.SetActive(false);
            if (this.gameObject.tag == "Monster")
                Initial.monsterNum = 1;
            else if (this.gameObject.tag == "Jelly")
                Initial.monsterNum = 2;
            SceneManager.LoadScene(2);
            Initial.lastPos = GameObject.FindGameObjectWithTag("Player").transform.position;
        }
    }
}
