using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MainMenuBalls : MonoBehaviour
{
    private Rigidbody2D menuBalls;
    void Start()
    {
        menuBalls = GetComponent<Rigidbody2D>();
        BallForce();
    }

    private void BallForce()
    {
        menuBalls.AddForce(Vector2.down * 1000);
    }

}
