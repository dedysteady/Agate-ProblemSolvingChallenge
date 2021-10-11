using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    // Rigidbody 2D bola
    private Rigidbody2D rigidBody2D;

    //kecepatan player
    public float speed;
    public float rotationOffset;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        //Reset bola ke tengah ketika menekan R
        if (Input.GetKeyDown(KeyCode.R))
        {
            ResetBall();
        }

        //Posisi mouse
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = 0;
        Vector3 objectPosition = Camera.main.WorldToScreenPoint(transform.position);
        
        //Jarak mouse dengan layar
        mousePosition.x = mousePosition.x - objectPosition.x;
        mousePosition.y = mousePosition.y - objectPosition.y;

        //Player bergerak ke mouse
        Vector3 targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        targetPosition.z = 0;
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
    }

    void ResetBall()
    {
        // Reset posisi menjadi (0,0)
        transform.position = Vector2.zero;

        // Reset kecepatan menjadi (0,0)
        rigidBody2D.velocity = Vector2.zero;
    }
}