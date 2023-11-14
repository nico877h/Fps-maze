using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class Thirdpersonmovement : MonoBehaviour
{

    public float speed = 15;
    public float jumpForce = 15f;
    public float gravity = -25f;
    public float rotationSpeed = 180;

    CharacterController controller;
    Vector3 moveVelocity;

    void Awake()
    {
        controller = GetComponent<CharacterController>();
    }
    // Update is called once per frame
    void Update()
    {
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");

        if (controller.isGrounded)
        {
            moveVelocity = new Vector3(horizontal, 0, vertical) * speed;

            if (Input.GetButtonDown("Jump"))
            {
                moveVelocity.y = jumpForce;
            }
        }
        moveVelocity.y += gravity * Time.deltaTime;
        controller.Move(transform.TransformDirection(moveVelocity) * Time.deltaTime);
    }
}