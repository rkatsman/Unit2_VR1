using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
String primitive;
Rigidbody2D rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        primitive = ("I am player");
        Debug.Log(primitive);
        rigidbody = null;
        Debug.Log(rigidbody);
         
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
