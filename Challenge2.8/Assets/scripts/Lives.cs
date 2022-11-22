using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lives : MonoBehaviour
{
    
    public static int enemy = 3;
    public Text enemyCount; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        enemyCount.text = "Lives: " + enemy;
        
        if(enemy == 0)
        {
        Debug.Log("GAME OVER");
        }
    }
    void OnCollisionEnter2D(Collision2D col){
        if(col.gameObject.tag == "enemy"){
            enemy = enemy - 1;
        }
    }
}