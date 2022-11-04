using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    
    Vector2 xMove;
    Transform player;

    // Start is called before the first frame update
    void Start()
    {
        xMove = new Vector2(0.0f,0.0f);
       player = gameObject.transform;

    }

    // Update is called once per frame
    void Update()
    {
        float rightLeft = Input.GetAxis("Horizontal");
        float upDown = Input.GetAxis("Vertical");
        xMove.x = rightLeft;
        xMove.y = upDown;
        player.Translate(xMove*Time.deltaTime); 
        if(rightLeft > 0){
            player.localScale= new Vector3(3.0f, 3.0f, 0.7f);
        }
        if(rightLeft < 0){
            player.localScale= new Vector3(-3.0f, 3.0f, 0.7f);
        }
    }
}
