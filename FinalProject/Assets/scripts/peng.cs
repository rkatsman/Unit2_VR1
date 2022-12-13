using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class peng : MonoBehaviour
{
   Vector2 xMove;
    Transform pengu;
    
    void Start()
    {
         xMove = new Vector2(1.0f,0.0f);
       pengu = gameObject.transform;
       
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
