using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
    public GameObject player;

    private Animator _anim;

    public Vector2 inputVector;
    public float speed = 0.0f;

    public void OnEnable()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        _anim = GetComponent<Animator>();

        speed = 10;
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        float vertical = Input.GetAxisRaw("Vertical");
        float horizontal = Input.GetAxisRaw("Horizontal");

        Vector2 inputVector = new Vector2(horizontal, vertical).normalized;

        rigidbody2D.velocity = inputVector * speed;
    }
}
