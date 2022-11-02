using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
     Vector2 xMove;
    Transform player;

    // Start is called before the first frame update
    void Start()
    {
        xMove = new Vector2(1.0f,0.0f);
       player = gameObject.transform;
    
 
    }

    // Update is called once per frame
    void Update()
    {
        float arrowInput = Input.GetAxis("Horizontal");
        float arrowInput1 = Input.GetAxis("Vertical");
        xMove.x = arrowInput;
        xMove.y = arrowInput1;
        player.Translate(xMove*Time.deltaTime);
        

    }
}
