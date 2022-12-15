using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class start : MonoBehaviour
{
    public void Start()
    {
    SceneManager.LoadScene("scene1");
    baiscMovemnet.health = 6;
    
    }
}
