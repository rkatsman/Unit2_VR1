using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    Vector2 xMove; 
   
    Transform circle;
    // Start is called before the first frame update
    void Start()
    {
        xMove = new Vector2(1.0f,0.0f);
        circle = gameObject.transform; 
    }

    // Update is called once per frame
    void Update()
    {
        circle.Translate(xMove*Time.deltaTime);
    }
}


