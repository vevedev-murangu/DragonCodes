using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuitGameButton : MonoBehaviour
{
    [SerializeField] public GameObject quitButton;

    void Start()
    {
        GetComponent<UnityEngine.UI.Button>().onClick.AddListener(QuitGame);

    }

    private void QuitGame()
    {
        Debug.Log("Voce saiu do Jogo");
        Application.Quit();
    }
}