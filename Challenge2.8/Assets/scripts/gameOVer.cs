using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameOVer : MonoBehaviour
{
    public void GAMEOVER()
    {
    SceneManager.LoadScene("menu");
    GameObject.FindGameObjectsWithTag("Player");
    
    }
    public void WON()
    {
    SceneManager.LoadScene("scene1");
    GameObject.FindGameObjectsWithTag("Player");
    
    }
    //public static FindObjectOfType( player);
}
