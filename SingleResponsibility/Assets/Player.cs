using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    PlayerInput playerInput;
    PlayerMovement playerMovement;

    private void Start()
    {
        playerInput = new PlayerInput();
        playerMovement = new PlayerMovement(GetComponent<Rigidbody2D>(), 5);
    }

    private void Update()
    {
        playerInput.SetInput();

        Debug.Log("Horizontal: " + playerInput.horizontal);
    }

    private void FixedUpdate()
    {
        playerMovement.Movement(playerInput.horizontal);
    }
}
