using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mymath : MonoBehaviour
{
    float num = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }
   
    
    // Update is called once per frame
    void Update()
    {
        product();
        Debug.Log(num);
    }

     void product()
    {
    num = num * 0.2f; 
    }
}
