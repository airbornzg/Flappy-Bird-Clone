using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [SerializeField] float flapStrength = 1f;
    [SerializeField] GameControl myGame;
    Rigidbody2D myRigidbody2D; 

    // Start is called before the first frame update
    void Start()
    {
        myRigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myRigidbody2D.velocity = Vector2.up * flapStrength;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        myGame.GameOver();
    }
}
