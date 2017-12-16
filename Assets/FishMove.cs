using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishMove : MonoBehaviour {

    public float FollowSpeed = 5f;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x<=-24) {
            transform.Translate(new Vector3(-1, 0, 0) * FollowSpeed * Time.deltaTime);
        }
        else if (transform.position.x>=30)
        {
            transform.Rotate(new Vector3(0,-180,0)*FollowSpeed*Time.deltaTime);
            transform.Translate(new Vector3(1, 0, 0) * FollowSpeed * Time.deltaTime);
        }
    }
}
