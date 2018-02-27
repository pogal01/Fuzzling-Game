using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moremove3 : MonoBehaviour
{
    static Animator animat;
    public float speed = 15.0F;
    public float jumpSpeed = 15.0F;
    public float gravity = 8.0F;
    public float rotateSpeed = 20.0F;
    public float rotateSpeedM = 20.0F;
    private Vector3 moveDirection = Vector3.zero;

    // Use this for initialization
    void Start()
    {
        animat = GetComponent<Animator>();



    }

    // Update is called once per frame
    void Update()
    {

        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotateSpeed;
        float rotationM = Input.GetAxis("Mouse X") * rotateSpeedM;
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;
        rotationM *= Time.deltaTime;



        transform.Translate(0, 0, translation);
        transform.Rotate(0, rotation, 0);
        transform.Rotate(0, rotationM, 0);

        if (translation != 0)
        {

            animat.SetBool("IsWalking", true);

        }
        else
        {
            animat.SetBool("IsWalking", false);
        }


        //if the character is on the ground
        CharacterController controller = GetComponent<CharacterController>();
        if (controller.isGrounded)
        {
            moveDirection = new Vector3(0, 0, Input.GetAxis("Vertical"));
            if (Input.GetButton("Jump"))
            {
                moveDirection.y = jumpSpeed;

                animat.SetBool("IsInAir", false);
            }
            else
            {
                animat.SetBool("IsInAir", true);
            }



        }

        //end of ground code


        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);

        //Rotate Player
        transform.Rotate(0, Input.GetAxis("Mouse X"), 0);
        transform.Rotate(0, Input.GetAxis("Horizontal"), 0);

    }
}