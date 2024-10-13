using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SubUI : MonoBehaviour
{
    public TMP_InputField playerNameInput;

    public void CharacterSelect(int InId)
    {
        GameManager.Character.player.PlayerSelect(InId);
    }

    public void NameInput()
    {
        GameManager.UI.playerName = playerNameInput.text;
        GameManager.UI.SetGameStart();
    }
}
