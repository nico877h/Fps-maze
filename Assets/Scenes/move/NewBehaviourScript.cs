using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 12f;
    public float gravity = -9.82f;
    public float jumpHeight = 1f;

    public Transform GroundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    Vector3 velocity;
    bool isGorunded;

    // Update is called once per frame
    void Update()
    {
        isGorunded = Physics.CheckSphere(GroundCheck.position, groundDistance, groundMask);

        if (isGorunded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        Debug.Log(isGorunded);
        if (Input.GetButtonDown("Jump") && isGorunded)
        {
            Debug.Log("hop");
            velocity.y = Mathf.Sqrt(jumpHeight * -0.75f * gravity);
        }

        velocity.y += gravity * Time.deltaTime; 

        controller.Move(velocity * Time.deltaTime);
    }
}