using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController cc;
    private Transform mainCamera;
    [SerializeField] private float mouseSenseX;
    [SerializeField] private float mouseSenseY;
    [SerializeField] private float speed;
    [SerializeField] private float maxSpeed;
    [SerializeField] private float gravity;
    [SerializeField] private float jumpHeight;
    [SerializeField] private float deaccSpeed;
    private float mouseX;
    private float mouseY;
    private Vector3 moveDirection = new Vector3();
    private float moveDirectionY;
    /*
     * Precondition: Runs on start
     * the mainCanrea must be a child of the player gameObject and be named "Main Camera"
     * player gameObject must have a charactorController, no rigidBody is needed
     * Postcondition:initialize variables and lockes the mouse
    */
    void Start()
    {
        cc = GetComponent<CharacterController>();
        mainCamera = transform.Find("Main Camera");
        //Cursor.lockState = CursorLockMode.Locked;//lock cursor
    }
    /*
     *Precondition: Runs on Everyframe
     *speed must be > 0 for object to move
     *jumpHeight must be > 0 for object to jump
     *gravity must be > 0 for object to fall
     *mouseSenseX and mouseSenseY must be > 0 for the player to look in different directions
     *input settings must be default values
     *Postconditions: Player is moved using WASD
     *Player can look in different directions by moving the mouse
     *SerializedFields values can be adjusted to adjust player movement
     */
    //Controls MouseMovements and WASD Movements
    void Update()
    {
        moveDirection = transform.TransformDirection(new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"))) * speed;
        moveDirection.y = moveDirectionY;//moveDirectionY is calculated serpately because moveDirection gets converted to world space
        if (cc.isGrounded)//when the charactor hits the ground the movement y becomes zero and the charactor can jump
        {
            moveDirection.y = 0;
            if (Input.GetKey(KeyCode.Space))//jump
            {
                moveDirectionY = jumpHeight;
            }
        }
        else//when the charactor is in the air gracity should take effect
        {
            moveDirectionY -= gravity * Time.deltaTime;
        }

        cc.Move(moveDirection * Time.deltaTime);//move the charactor

        mouseY += -Input.GetAxis("Mouse Y") * mouseSenseY;
        mouseY = Mathf.Clamp(mouseY, -90, 90);//clamp the y camrera angle
        mouseX += Input.GetAxis("Mouse X") * mouseSenseX;
        mainCamera.localRotation = Quaternion.AngleAxis(mouseY, Vector3.right);//looking up and down only changes the rotation of the camrera
        transform.localRotation = Quaternion.AngleAxis(mouseX, transform.up);//looking side to side changes the rotation of the whole charactor
    }
}

