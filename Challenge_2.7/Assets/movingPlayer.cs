using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingPlayer : MonoBehaviour
{
     
    Vector2 xMove;
    Transform player;
    public Animator animator;
     Rigidbody2D playerBody;
      public float thrust = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        xMove = new Vector2(0.0f,0.0f);
       player = gameObject.transform;
       playerBody = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        float rightLeft = Input.GetAxis("Horizontal");
        float upDown = Input.GetAxis("Vertical");
        xMove.x = rightLeft*thrust;
        //xMove.y = upDown;
        player.Translate(xMove*Time.deltaTime); 
        if(rightLeft > 0){
            player.localScale= new Vector3(5.0f, 5.0f, 0.7f);
        }
        if(rightLeft < 0){
            player.localScale= new Vector3(-5.0f, 5.0f, 0.7f);
        }
        animator.SetFloat("speed", (rightLeft));
        /*if(Input.GetKey("up")) {
            playerBody.AddForce(transform.up * thrust);


        }
        */
        if (upDown > 0)
        {
           playerBody.AddForce(transform.up * thrust);

        }else if(upDown < 0){
            
        }
    }
}
//jjlk