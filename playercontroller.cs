//Taylor Burdgess, Charlie Garrido

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//TASK 2: Create a Second Enemy Type with a Different Movement Pattern and Spawn Pattern
public class Enemy1 : MonoBehaviour
{
  public float speed= 5f;

  void Start()
  {
     float transform.position.x = Random.Range(-5f, 5f);
     transform.position = new Vector3(transform.position.x * -1, y, 0);
  }

  void Update()
  {
   //Movement player
   transform.Translate(new Vector3(horizontalInput, verticalInput, 0) * Time.deltaTime * playerSpeed);

    if(transform.position x > horizontalScreenLimit || transform.position x < -horizontalScreenLimit)
    {
        transform.positionn = new Vector3(transform.position.x * -1, y, 0);
    }
  }
}

public class Enemy2 : MonoBehaviour
{
  public float speed= 3f;
  public float moveDirection = 2f;

  void Start()
  {
     float transform.position.x = Random.Range(-5f, 5f);
     transform.position = new Vector3(transform.position.x * -1, y, 0);
  }

  void Update()
  {
   transform.Translate(new Vector3(horizontalInput, verticalInput, 0) * Time.deltaTime * playerSpeed);

    if(transform.position x > horizontalScreenLimit || transform.position x < -horizontalScreenLimit)
    {
        transform.positionn = new Vector3(transform.position.x * -1, y, 0);
    }
  }
}

