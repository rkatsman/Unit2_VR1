using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UiCode : MonoBehaviour
{ 
    private int acorns = 0;
    public Text acornText; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(acorns);
        acornText.text = "Acorns : " + acorns;
        if(acorns == 2)
        {
            Debug.Log(acorns);
        SceneManager.LoadScene("win");
        }
        //jj
    }
    void OnCollisionEnter2D(Collision2D col){
        if(col.gameObject.tag == "acorn"){
            acorns = acorns + 1;
        }

    }
}
