using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
string primitive = ("I am player");
Rigidbody2D rigidbody = null;
    // Start is called before the first frame update
    void Start()
    {
     
        Debug.Log(primitive);
        Debug.Log(rigidbody);
         
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
