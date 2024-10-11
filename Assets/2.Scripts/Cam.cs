using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class Cam : MonoBehaviour
{
    private Vector3 _camPos = new Vector3(0, 0, -10);

    private void FixedUpdate()
    {
        if (!GameManager.Character.player)
            return;

        transform.position = 
            GameManager.Character.player.transform.position + _camPos;
    }
}
