using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DesativarScene : MonoBehaviour
{
    [SerializeField] public GameObject creditsScreen;

    private void Start()
    {
        creditsScreen.SetActive(false);

        GetComponent<UnityEngine.UI.Button>().onClick.AddListener(ShowCredits);

    }


    private void ShowCredits()
    {
        creditsScreen.SetActive(false);
    }

}