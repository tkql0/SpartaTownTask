using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class MainUI : MonoBehaviour
{
    [SerializeField]
    private TMP_Text timeText;

    private void Update()
    {
        timeText.text = DateTime.Now.ToString("HH : mm");
    }

    public void ButtonClick()
    {
        GameManager.UI.SetGameStop();
    }
}
