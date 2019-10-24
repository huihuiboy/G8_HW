using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour {

    Animator chicken;
    bool r_run;
    
    
	// Use this for initialization
	void Start ()
    {
        chicken = gameObject.GetComponent<Animator>();
        r_run = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyUp(KeyCode.E))
        {
            //Reset the "Eat" trigger
            chicken.ResetTrigger("Eat");
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            //Send the message to the Animator to activate the trigger parameter named "Crouch"
            chicken.SetTrigger("Eat");
        }
        if (Input.GetKey(KeyCode.R))
        {
            r_run = true;
        }
        //Otherwise the GameObject cannot jump.
        else r_run = false;

        //If the GameObject is not jumping, send that the Boolean “Jump” is false to the Animator. The jump animation does not play.
        if (r_run == false)
            chicken.SetBool("Run", false);

        //The GameObject is jumping, so send the Boolean as enabled to the Animator. The jump animation plays.
        if (r_run == true)
            chicken.SetBool("Run", true);
    }
}
