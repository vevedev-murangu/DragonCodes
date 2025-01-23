using UnityEngine;
using UnityEngine.SceneManagement;

public class TryAgain : MonoBehaviour
{
    public GameObject canvas; 
    public int sceneIndex;    

    void Update()
    {
        
        if (canvas.activeSelf && Input.GetKeyDown(KeyCode.Return))
        {
            
            SceneManager.LoadScene(sceneIndex);
        }
    }
}


