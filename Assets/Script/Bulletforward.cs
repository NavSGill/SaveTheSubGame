using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulletforward : MonoBehaviour {

    [SerializeField]
    float mSpeed;
    Rigidbody2D mRigidBody2D;

    void Awake()
    {
        // Must be done in Awake() because SetDirection() will be called early. Start() won't work.
        mRigidBody2D = GetComponent<Rigidbody2D>();

        // Set a default direction
        mRigidBody2D.velocity = Vector2.right * mSpeed;
    }
}
