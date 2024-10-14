using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : Character
{
    public GameObject talkButton;

    public bool isButtonSpawn = false;

    public void ButtonSpawn()
    {
        isButtonSpawn = true;
        talkButton.SetActive(true);
    }
}
