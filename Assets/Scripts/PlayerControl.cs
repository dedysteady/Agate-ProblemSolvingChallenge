using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    // Tombol untuk menggerakkan ke atas
    public KeyCode upButton = KeyCode.W;
 
    // Tombol untuk menggerakkan ke bawah
    public KeyCode downButton = KeyCode.S;

    // Tombol untuk menggerakkan ke kanan
    public KeyCode rightButton = KeyCode.D;

    // Tombol untuk menggerakkan ke kiri
    public KeyCode leftButton = KeyCode.A;
 
    // Kecepatan gerak
    public float speed = 15.0f;
 
    // Batas atas, bawah, kanan dan kiri game scene (Batas bawah menggunakan minus (-))
    public float yBoundary = 9.0f;
    public float xBoundary = 9.0f;
 
    // Rigidbody 2D bola ini
    private Rigidbody2D rigidBody2D;

    void Start()
    {
    rigidBody2D = GetComponent<Rigidbody2D>();
    }
   
    void Update()
    {
    // Dapatkan kecepatan bola sekarang.
        Vector2 velocity = rigidBody2D.velocity;
 
        // Jika pemain menekan tombol ke atas, beri kecepatan positif ke komponen y (ke atas).
        if (Input.GetKey(upButton))
        {
            velocity.y = speed;
        }
 
        // Jika pemain menekan tombol ke bawah, beri kecepatan negatif ke komponen y (ke bawah).
        else if (Input.GetKey(downButton))
        {
            velocity.y = -speed;
        }
 
        // Jika pemain tidak menekan tombol apa-apa, kecepatannya nol.
        else
        {
            velocity.y = 0.0f;
        }

        // Jika pemain menekan tombol ke kanan, beri kecepatan positif ke komponen x (ke kanan).
        if (Input.GetKey(rightButton))
        {
            velocity.x = speed;
        }
 
        // Jika pemain menekan tombol ke left, beri kecepatan negatif ke komponen x (ke left).
        else if (Input.GetKey(leftButton))
        {
            velocity.x = -speed;
        }
 
        // Jika pemain tidak menekan tombol apa-apa, kecepatannya nol.
        else
        {
            velocity.x = 0.0f;
        }
 
        // Masukkan kembali kecepatannya ke rigidBody2D.
        rigidBody2D.velocity = velocity;

        // Dapatkan posisi bola sekarang.
        Vector3 position = transform.position;
 
        // Jika posisi bola melewati batas atas (yBoundary), kembalikan ke batas atas tersebut.
        if (position.y > yBoundary)
        {
            position.y = yBoundary;
        }
 
        // Jika posisi bola melewati batas bawah (-yBoundary), kembalikan ke batas bawah tersebut.
        else if (position.y < -yBoundary)
        {
            position.y = -yBoundary;
        }
 
        // Masukkan kembali posisinya ke transform.
        transform.position = position;

        // Masukkan kembali kecepatannya ke rigidBody2D.
        rigidBody2D.velocity = velocity;

 
        // Jika posisi bola melewati batas kanan (xBoundary), kembalikan ke batas kanan tersebut.
        if (position.x > xBoundary)
        {
            position.x = xBoundary;
        }
 
        // Jika posisi bola melewati batas kiri (-xBoundary), kembalikan ke batas kiri tersebut.
        else if (position.x < -xBoundary)
        {
            position.x = -xBoundary;
        }
 
        // Masukkan kembali posisinya ke transform.
        transform.position = position;
    }

}
