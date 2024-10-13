using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SubUI : MonoBehaviour
{
    public void CharacterSelect(int InId)
    {
        GameManager.Character.playerId = InId;
    }

    public void NameInput()
    {

    }
}
