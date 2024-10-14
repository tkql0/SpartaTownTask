using UnityEngine;

public class Character : MonoBehaviour
{
    public float speed = 5f;

    protected Rigidbody2D _rigidbody2D;
    protected SpriteRenderer _spriteRenderer;

    protected Animator _animator;

    protected Vector2 _inputPos = Vector2.zero;

    protected void Movement(Vector2 InDirection)
    {
        InDirection *= speed;

        _rigidbody2D.velocity = InDirection;
    }
}
