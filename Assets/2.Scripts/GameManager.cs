using UnityEngine;

public class GameManager : MonoSingleTon<GameManager>
{
    static public CharacterControl Character { get; private set; }
    static public UIControl UI { get; private set; }

    private void Awake()
    {
        Character = new();
        UI = new();

        Application.targetFrameRate = 60;
    }

    private void OnEnable()
    {
        Character.OnEnable();
        UI.OnEnable();
    }

    private void OnDisable()
    {

    }
}