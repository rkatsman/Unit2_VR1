using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerWalking : MonoBehaviour
{
     
    Vector2 xMove;
    Transform player;
    public Animator animator;
    float thrust = 5f;
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
        xMove.x = rightLeft *thrust;
        xMove.y = upDown*thrust;
        player.Translate(xMove*Time.deltaTime); 
        if(rightLeft > 0){
            player.localScale= new Vector3(5.0f, 5.0f, 0.7f);
        }
        if(rightLeft < 0){
            player.localScale= new Vector3(-5.0f, 5.0f, 0.7f);
        }
        animator.SetFloat("speed", Mathf.Abs(rightLeft));
        animator.SetFloat("up", Mathf.Abs(upDown));

    }
}
