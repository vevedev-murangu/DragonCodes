using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseOnCanvas : MonoBehaviour
{
    void OnEnable()
    {
        Time.timeScale = 0f;
    }

    void OnDisable()
    {
        Time.timeScale = 1f;
    }
}