using UnityEngine;

public class Character : MonoBehaviour
{
    protected Rigidbody2D _rigidbody2D;
    protected SpriteRenderer _spriteRenderer;

    protected Vector2 _inputPos = Vector2.zero;
    public Camera _camera;
}
