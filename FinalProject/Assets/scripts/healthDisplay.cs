using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthDisplay : MonoBehaviour
{
    private int health = 0;
   public Text healthText;


    // Update is called once per frame
    void Update()
    {
       healthText.text = "HEALTH : " + baiscMovemnet.health;

      
    }
}
