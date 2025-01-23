using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuE : MonoBehaviour
{
    [SerializeField]
    private int sceneBuildIndex = 0; 

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.E))
        {
            ChangeScene();
        }
    }

    private void ChangeScene()
    {
        
        Debug.Log("Mudando para a cena: " + sceneBuildIndex);
        SceneManager.LoadScene(sceneBuildIndex);
    }
}
