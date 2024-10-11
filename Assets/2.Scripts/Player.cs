using UnityEngine;
using UnityEngine.InputSystem;

public class Player : Character
{
    private void Awake()
    {
        _cam = Camera.main;
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _spriteRenderer = GetComponentInChildren<SpriteRenderer>();
    }

    private void Update()
    {
        GameManager.Character.player = this;
    }

    private void FixedUpdate()
    {
        Movement(_inputPos);
    }

    private void OnMove(InputValue InValue)
    {
        _inputPos = InValue.Get<Vector2>().normalized;
    }

    private void OnLook(InputValue InValue)
    {
        Vector2 newAim = InValue.Get<Vector2>();
        Vector2 worldPos = _cam.ScreenToWorldPoint(newAim);
        newAim = (worldPos - (Vector2)transform.position).normalized;

        _spriteRenderer.flipX = newAim.x > 0 ? true : false;
    }
}
