using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
using UnityEditor.U2D.Animation;

public class Player : Character
{
    [SerializeField]
    private RuntimeAnimatorController[] animCon;
    [SerializeField]
    private Sprite[] spriteImage;

    public TMP_Text name;
    public RaycastHit2D[] _inTarget;
    public LayerMask targetMask;
    public Camera _cam;

    private void Awake()
    {
        _cam = Camera.main;
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _spriteRenderer = GetComponentInChildren<SpriteRenderer>();
        _animator = GetComponentInChildren<Animator>();
    }

    private void Update()
    {
        GameManager.Character.player = this;
        ObjectScan();
    }

    private void FixedUpdate()
    {
        Movement(_inputPos);
    }

    public void PlayerSelect(int InKey)
    {
        _spriteRenderer.sprite = spriteImage[InKey];
        _animator.runtimeAnimatorController = animCon[InKey];
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.black;

        Gizmos.DrawSphere(transform.position, 5f);
    }

    private void ObjectScan()
    {
        _inTarget = Physics2D.CircleCastAll(transform.position,
            5f, Vector2.zero, 0, targetMask);

        if (_inTarget.Length == 0)
            return;

         _inTarget[0].transform.TryGetComponent<NPC>(out var OutNPC);

        if(!OutNPC.isButtonSpawn)
            OutNPC.ButtonSpawn();
        // TODO :: 대화버튼 활성화
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
