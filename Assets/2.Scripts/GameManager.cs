using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoSingleTon<GameManager>
{


    private void Awake()
    {


        Application.targetFrameRate = 60;
    }

    private void OnEnable()
    {

    }

    private void OnDisable()
    {

    }
}