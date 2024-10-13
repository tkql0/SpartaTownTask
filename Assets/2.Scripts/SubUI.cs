using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SubUI : MonoBehaviour
{
    public TMP_InputField playerNameInput;

    public Image playerImage;
    public Sprite[] characterImage;

    public void CharacterSelect(int InKey)
    { // ĳ���� ���� ��ư �޼���
        GameManager.Character.player.PlayerSelect(InKey);
        playerImage.sprite = characterImage[InKey];
    }

    public void NameInput()
    { // ĳ���� �̸� ��ư �޼���
        GameManager.Character.player.name.text = playerNameInput.text;
        GameManager.UI.SetGameStart();
    }
}
