﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollider : MonoBehaviour {

    bool touch = false;
    bool jump = false;
    //bool highJump = false;

    public bool isTouch()
    {
        return touch;
    }

    public bool isJump()
    {
        return jump;
    }

    /*public bool isHighJump()
    {
        return highJump;
    }*/

    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () { 
        //Debug.Log(jump);
        //Debug.Log(time);
    }

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("Enter");
        if (other.gameObject.tag == "Block")
        {
            jump = true;
            //touch = true;
        }
    }

    /*void JumpTime()
    {
        time = 0;
        float span = 1.0f;
        time += Time.deltaTime;
        if(time < span)
        {
            jump = true;
        }
    }*/
    
    void OnTriggerStay(Collider other)
    {
        //Debug.Log("Stay");
        if(other.gameObject.tag == "Block")
        {
            //touch = true;
            //jump = false;
        }
    }

    void OnTriggerExit(Collider other)
    {
        //Debug.Log("Exit");
        if(other.gameObject.tag == "Block")
        {
            //touch = false;
            jump = false;
            //highJump = false;
        }
    }

    /*private void OnCollisionStay(Collision collision)
    {
        isTouch = true;
    }*/

    /*private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Block")
        {
            touch = false;
        }
        //isTouch = false;

    }*/

}
