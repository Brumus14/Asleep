using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed = 2f;

    // Update is called once per frame
    void FixedUpdate()
    {

        Vector2 temp = transform.position;
        if(Input.GetAxis("Horizontal") > 0)
        {

            temp.x += moveSpeed * Time.deltaTime;

        }
        else if (Input.GetAxis("Horizontal") < 0)
        {

            temp.x -= moveSpeed * Time.deltaTime;

        }

        if (Input.GetAxis("Vertical") > 0)
        {

            temp.y += moveSpeed * Time.deltaTime;

        }
        else if (Input.GetAxis("Vertical") < 0)
        {

            temp.y -= moveSpeed * Time.deltaTime;

        }
        transform.position = temp;

        if(transform.position.x <= -10)
        {
            
        }
    }



}
