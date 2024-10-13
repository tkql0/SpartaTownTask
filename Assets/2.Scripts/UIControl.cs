using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIControl
{
    //public string playerName = null;

    public void OnEnable()
    {
        SetGameStop();
    }

    private void OnDisable()
    {

    }

    public void SetGameStop() => Time.timeScale = 0;
    public void SetGameStart() => Time.timeScale = 1;
}
