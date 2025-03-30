using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //private variables arent seen in Unity, public are
    private float playerSpeed;
    private float horizontalInput;
    private float verticalInput;

    private float horizontalScreenLimit = 8.5f;
    private float verticalUpperLimit = 0.6f;
    private float verticalLowerLimit = -3.5f;

    void SetTransformY(float n)
    {
        transform.position = new Vector3(transform.position.x, n, transform.position.z);
    }

    //called at the start of the game
    void Start()
    {
        playerSpeed = 10.0f;
        //transform.position = new Vector3(2, 3, 4);
    }

    // Update is called once per frame
    //Time.deltaTime to fix
    void Update()
    {
        Movement();
        //transform.position = new Vector3(2, 3, 4);
    }

    void Movement()
    {
        //Read Input from player
        horizontalInput = Input.GetAxis ("Horizontal");
        verticalInput = Input.GetAxis ("Vertical");
        //move the player
        transform.Translate(new Vector3(horizontalInput, verticalInput, 0) * Time.deltaTime * playerSpeed);

        //Player leaves screen Horizontally
        if(transform.position.x > horizontalScreenLimit || transform.position.x < -horizontalScreenLimit)
        {
                transform.position = new Vector3(transform.position.x * -1, transform.position.y, 0);
        } 

        //Blocks the player from moving past upper & lower screen limits
        else if (transform.position.y > verticalUpperLimit) 
        { 
            SetTransformY(0.6f); 
        }
        else if (transform.position.y < verticalLowerLimit) 
        { 
            SetTransformY(-3.5f); 
        }

    }

    
}
