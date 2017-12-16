using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Submarine : MonoBehaviour {
    
    public float MovementSpeed = 10;

	float Maxforward;


    void FixUpdate()
    {

    }


    void Update () {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

//STOP Y AXIS
        
        if (transform.position.y >= -3.25 && transform.position.y <= 4.17)
        {
            
            transform.position += new Vector3(horizontal, vertical, 0) * Time.deltaTime * MovementSpeed;
            //transform.position += new Vector3(horizontal, vertical, 0) * Time.deltaTime * MovementSpeed;
        }

        else if (transform.position.y >= 4.17)
        {
            
            transform.position = new Vector3(transform.position.x, 4.169f, transform.position.z);
        }
        else if (transform.position.y <= -3.25)
        {
            
            transform.position = new Vector3(transform.position.x,-3.249f, transform.position.z);
        }

//STOP X AXIS

		if (transform.position.x >= -19.7 && transform.position.x <= -15) {
			
			transform.position += new Vector3 (horizontal, vertical, 0) * Time.deltaTime * MovementSpeed;
		}

		else if (transform.position.x >= -15)
		{
			
			transform.position = new Vector3(14.9f,transform.position.y, transform.position.z);
		}
		else if (transform.position.x <= -19.7)
		{
			
			transform.position = new Vector3(-19.8f,transform.position.y, transform.position.z);
		}
//RESET POSITION
       
        if (transform.position.x >= 9.75)
        {
            //Debug.Log("4");
            transform.position += new Vector3(-20.6f, transform.position.y, transform.position.z);
        }
    }
}
