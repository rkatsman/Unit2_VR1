using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enime : MonoBehaviour
{
    
    Vector2 xMove;
    Transform enime1;
    // Start is called before the first frame update
    void Start()
    {
         xMove = new Vector2(1.0f,0.0f);
       enime1 = gameObject.transform;
       
    }

    // Update is called once per frame
    void Update()
    {
        //float rightLeft = Input.GetAxis("Horizontal");
    
        enime1.Translate(xMove*Time.deltaTime);
        /*if(rightLeft > 0){
            enime1.localScale= new Vector3(1.0f, 1.0f, 0.7f);
        }
        if(rightLeft < 0){
            enime1.localScale= new Vector3(-1.0f, 1.0f, 0.7f);
        }*/
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "box")
        {
           xMove = new Vector2(-1.0f,0.0f);
        }else if(collision.gameObject.tag == "box2"){
            xMove = new Vector2(1.0f,0.0f);
        }
    }
}
