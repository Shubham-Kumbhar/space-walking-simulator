using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charamoment : MonoBehaviour
{
    public float movespeed, walkspeed,runspeed;

    public Vector3 movediriction;






    public CharacterController contorler;
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        contorler= GetComponent <CharacterController>();
        anim = GetComponentInChildren <Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }






    public void move()
    {
        float moveZ = Input.GetAxis("Vertical");
        float moveX = Input.GetAxis("Horizontal");


        movediriction = new Vector3(moveX, 0, moveZ);


        movediriction = transform.TransformDirection(movediriction);



        if (movediriction != Vector3.zero && !Input.GetKey(KeyCode.LeftShift))
        {
            run();
        }
        else if (movediriction != Vector3.zero && Input.GetKey(KeyCode.LeftShift))
        {
            walk();
        }
        else if (movediriction == Vector3.zero)
        {
            idel();
        }
        movediriction *= movespeed; 
        contorler.Move(movediriction * Time.deltaTime);

    }
    public void walk()
    {
        movespeed = walkspeed;
        anim.SetFloat("speed", 1 ,0.1f,Time.deltaTime);
    }
    public void idel()
    {
        movespeed = 0;
        anim.SetFloat("speed", 0 , 0.1f, Time.deltaTime);
    }
    public void run()
    {
        movespeed = runspeed;
        anim.SetFloat("speed", 0.5f , 0.1f, Time.deltaTime);
    }
}
