using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput
{
    public float horizontal { get; private set; }

    public void SetInput()
    {
        horizontal = Input.GetAxis("Horizontal");
    }
}
