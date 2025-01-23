using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    
    [SerializeField] private int sceneIndex;

    private void Start()
    {
        GetComponent<UnityEngine.UI.Button>().onClick.AddListener(LoadScene);
    }
    private void LoadScene()
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
