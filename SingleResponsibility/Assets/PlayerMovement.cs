using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement
{
    Rigidbody2D rigidbody;
    float movementSpeed;

    public PlayerMovement(Rigidbody2D _rigidbody,float _movementSpeed)
    {
        rigidbody = _rigidbody;
        movementSpeed = _movementSpeed;
    }

    public void Movement(float horizontal)
    {
        Vector2 vec = new Vector2(horizontal * movementSpeed, 0);
        rigidbody.velocity = vec;
    }
}
