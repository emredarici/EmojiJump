using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlatformMove : MonoBehaviour
{
    public float platformSpeed;
    private float platformMovementDirection = 0;
    private Rigidbody2D platformRb;
    private Platform platformMoveScript;
    void Start()
    {
        platformRb = GetComponent<Rigidbody2D>();
        platformMoveScript = new Platform();
        platformMoveScript.Enable();
        platformMoveScript.PlatformMove.Newaction.performed += moving =>
        {
            platformMovementDirection = moving.ReadValue<float>();
        };
    }

    void FixedUpdate()
    {
        platformRb.velocity = new Vector2(platformMovementDirection * platformSpeed, platformRb.velocity.y);
    }
}
