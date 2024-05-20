using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charachter : MonoBehaviour
{
    private CharacterController controller;
    Vector3 move=Vector3.zero;
    float speed = 20f;
    float inputX;
    float inputY;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
       controller = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
    }


  
    // Update is called once per frame
    void Update()
    {

         if(Input.GetAxis("Horizontal")!=0 || Input.GetAxis("Vertical")!=0){
            anim.SetFloat("hiz", 0.4f);
        }else{
            anim.SetFloat("hiz", 0.0f);
        }


        inputX = Input.GetAxis("Horizontal");
        inputY = Input.GetAxis("Vertical");
        move = new Vector3(inputX, 0, inputY)*Time.deltaTime*speed;
        

        controller.Move(move);
      

    }
}
