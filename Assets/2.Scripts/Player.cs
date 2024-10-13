using UnityEngine;
using UnityEngine.InputSystem;

public class Player : Character
{
    public RuntimeAnimatorController[] animCon;
    public Sprite[] spriteImage;

    Animator anim;

    private void Awake()
    {
        _cam = Camera.main;
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _spriteRenderer = GetComponentInChildren<SpriteRenderer>();
        anim = GetComponentInChildren<Animator>();
    }

    public void PlayerSelect(int InId)
    {
        _spriteRenderer.sprite = spriteImage[InId];
        anim.runtimeAnimatorController = animCon[InId];
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
        // 위에 코드를 남긴 이유는 시간이 남는다면 공격도 넣어볼까해서
    }
}
