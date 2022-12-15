using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class gameover : MonoBehaviour
{
	public void GAMEOVER()
    {
    SceneManager.LoadScene("scene1");
    GameObject.FindGameObjectsWithTag("Player");
    baiscMovemnet.health = 6;
    
    }
    public void WON()
    {
    SceneManager.LoadScene("scene1");
    GameObject.FindGameObjectsWithTag("Player");
    
    }

}
