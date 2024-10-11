using UnityEngine;
using UnityEngine.InputSystem;

public class Player : Character
{
    private void Awake()
    {
        _camera = Camera.main;
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _spriteRenderer = GetComponentInChildren<SpriteRenderer>();
    }

    private void Update()
    {
        
    }

    private void FixedUpdate()
    {
        ApplyMovement(_inputPos);
    }

    public void OnMove(InputValue value)
    {
        _inputPos = value.Get<Vector2>().normalized;
    }

    public void OnLook(InputValue value)
    {
        Vector2 newAim = value.Get<Vector2>();
        Vector2 worldPos = _camera.ScreenToWorldPoint(newAim);
        newAim = (worldPos - (Vector2)transform.position).normalized;

        _spriteRenderer.flipX = newAim.x > 0 ? true : false;
    }

    protected void ApplyMovement(Vector2 direction)
    {
        direction = direction * 5;

        _rigidbody2D.velocity = direction;
    }
}
