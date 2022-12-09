using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class baiscMovemnet : MonoBehaviour
{
    Vector2 xMove;
    Transform player;
    public Animator animator;
    Rigidbody2D playerBody;
    public float thrust = 250f;
    public float speedObject = 2f;
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
        
        xMove.x = rightLeft *speedObject;
        if ( Input.GetKeyDown(KeyCode.UpArrow))
        {
           if(playerBody.velocity.y == 0 ){
               playerBody.AddForce(transform.up * thrust);
           }

        }
        //xMove.y = upDown*thrust;
        player.Translate(xMove*Time.deltaTime); 
        if(rightLeft > 0){
            player.localScale= new Vector3(1.0f, 1.0f, 0.7f);
        }
        if(rightLeft < 0){
            player.localScale= new Vector3(-1.0f, 1.0f, 0.7f);
        }
        animator.SetFloat("run", Mathf.Abs(rightLeft));
        animator.SetFloat("up", Mathf.Abs(upDown));
    }
}
