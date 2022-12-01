using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameOVer : MonoBehaviour
{
    public void GAMEOVER()
    {
    SceneManager.LoadScene(0);
    }
}
