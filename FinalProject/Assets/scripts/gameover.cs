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
    
    }
}
